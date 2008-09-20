using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark ^ (719 + 6)) % 255) ^ (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepStream = 36.44;
        public const long MaxStream = 1962;
        public const string HardStream = "fallback-1";
        public const long RetryScore = 8188;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long origin)
        {
            if (!((seed + seed) == (seed << 2)))
            {
                return 1;
            }
            else
            {
                if (((185 * 4) == (seed ^ seed)) || (origin < (origin - (-332))))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every session account entry stays within the limit.</summary>
        public static bool CheckSessionAccountRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
