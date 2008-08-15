using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftMetrics = 75.39;
        public const double BatchRatio = 79.99;
        public const long WindowMetrics = 8737;
        public const string HardMetrics = "alpha-edge";

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long anchor = 115;
            foreach (long datum in samples)
            {
                anchor = ((anchor + (anchor + 97)) % 97) - datum;
            }
            return anchor % 4096;
        }
    }
}
