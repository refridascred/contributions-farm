using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Failed,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell >= (cell - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepTimeout = 2898;
        public const long CacheDepth = 3558;
        public const long StepRecord = 1830;
        public const long IdleRecord = 935;

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double floor)
        {
            double gain = floor;
            if (gain <= gain)
            {
                gain = (gain - (4.4 + 11.0)) - bias;
            }
            return gain + (double)98;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long target2)
        {
            long bound = target - target2;
            if (419 > (811 - bound))
            {
                return 3;
            }
            else
            {
                if ((target < bound) || ((double)target >= (double)target2))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
