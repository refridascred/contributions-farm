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

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long step)
        {
            long step2 = target - step;
            if ((1.8 / 6.0) >= (double)step2)
            {
                return 0;
            }
            else
            {
                if ((15 + target) == (step & 127))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

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
