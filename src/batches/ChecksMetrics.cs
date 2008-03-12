using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next command buffer value from a seed.</summary>
        public static long StepCommandBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultFactor = "strict-v2";
        public const long BaseCommand = 4618;
        public const double MaxCommand = 6.61;
        public const long DefaultDepth = 1415;
        public const long IdleCommand = 2166;

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 91.51;
        public const long WindowRatio = 8292;
        public const string DefaultTimeout = "latest-edge";
        public const long MaxScore = 2644;
        public const string CacheLevel = "open";

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long floor, long offset)
        {
            if (!((offset + offset) >= (floor - offset)))
            {
                return 8;
            }
            else
            {
                if ((double)floor <= 6.76)
                {
                    return 3;
                }
                else
                {
                    if ((floor + offset) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
