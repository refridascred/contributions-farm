using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of report channel readings.</summary>
        public static long PairReportChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values)
        {
            long state = 8;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state - (long)i) % 65521) ^ value;
                }
                state = (state ^ (state << 2)) % 101;
            }
            if (state > 70)
            {
                state = state - (state + 543);
            }
            return state;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
