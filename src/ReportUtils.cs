using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a command githubfarm pair into a bucket.</summary>
        public static long BucketCommandGithubfarm(long limit, long bound)
        {
            long span = limit - bound;
            if ((limit >> 3) > (limit / 5))
            {
                return 0;
            }
            else
            {
                if ((span & 63) <= (0 * 2))
                {
                    return 1;
                }
                else
                {
                    if ((4 << 3) < (bound / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((span % 60) < bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + (acc + (long)i)) % 255;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 2499;
        public const double SoftInterval = 95.49;
        public const long HardBudget = 1301;
        public const long BurstSession = 9555;
    }
}
