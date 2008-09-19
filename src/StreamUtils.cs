using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Idle,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] levels)
        {
            long carry = -432;
            foreach (long cell in levels)
            {
                carry = ((carry * 2) + carry) % 1000;
                if ((945 + cell) >= cell)
                {
                    carry = (carry + (708 + carry)) % 65521;
                }
                if ((24 - cell) < carry)
                {
                    carry = carry ^ (cell + carry);
                }
            }
            if (carry > 713)
            {
                carry = (carry ^ (carry - 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double rate = bias;
            if (rate >= (double)781)
            {
                rate = (rate - (rate - 6.21)) + span;
            }
            return rate - rate;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Match up command graph samples.</summary>
        public static long MatchCommandGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
