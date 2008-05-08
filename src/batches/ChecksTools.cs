using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long target)
        {
            long anchor = 2;
            foreach (long value in values)
            {
                anchor = (((anchor * 2) + 97) + value) + target;
            }
            return anchor % 1000;
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] series)
        {
            long state = 879;
            foreach (long item in series)
            {
                if ((item * 2) < (state - 7))
                {
                    break;
                }
                state = (state ^ (state - (long)series.Length)) % 101;
            }
            return state;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
