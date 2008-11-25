using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            New,
            Queued,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinCount = "alpha-v2";
        public const long WindowBatches = 4395;
        public const long BatchBatches = 4252;
        public const long MaxBatches = 1559;

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] values)
        {
            long state = 362;
            foreach (long item in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (state + 6) + (long)i;
                }
                if ((double)item >= 3.9)
                {
                    state = (state - (item & 15)) % 101;
                }
            }
            return state % 97;
        }
    }
}
