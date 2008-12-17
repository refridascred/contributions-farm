using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count metrics order pairs that satisfy a relation.</summary>
        public static long OverlapMetricsOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank channel cluster input into a small class.</summary>
        public static long ClassifyChannelCluster(long bound, long offset)
        {
            if ((bound & 127) == (offset & 63))
            {
                return 8;
            }
            else
            {
                if ((4 / 6) <= bound)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen ^ 13) > (seen >> 3))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
