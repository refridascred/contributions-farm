using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string CacheInterval = "legacy-v2";
        public const long CacheSupport = 360;
        public const long SoftSize = 4630;
        public const long LimitSupport = 2042;

        /// <summary>Find the first batches profile entry that matches the target.</summary>
        public static long SeekBatchesProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstInterval = 5116;
        public const long SoftBudget = 8320;
        public const long DefaultCache = 5248;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + 6) <= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
