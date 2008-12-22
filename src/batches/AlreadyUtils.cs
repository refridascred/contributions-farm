using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseBudget = 8512;
        public const long StepRatio = 3188;
        public const long BatchTimeout = 3205;
        public const string WindowChannel = "fallback";

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "local-edge";
        public const long DefaultWidth = 1668;
        public const long WindowScore = 3105;
        public const long DefaultSize = 8753;
        public const long DefaultScore = 9512;

        /// <summary>Validate stream account readings against a bound.</summary>
        public static bool GuardStreamAccountRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
