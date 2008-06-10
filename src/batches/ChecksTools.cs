using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long step, long floor)
        {
            long slot = step + floor;
            if ((double)130 >= (double)step)
            {
                return 2;
            }
            else
            {
                if (((12 + 38) <= step) || ((floor - slot) >= ((-5) ^ floor)))
                {
                    return 8;
                }
                else
                {
                    if (slot > (floor - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            if ((seed * 4) > (seed2 << 1))
            {
                return 2;
            }
            else
            {
                if ((seed ^ 768) < seed)
                {
                    return 4;
                }
                else
                {
                    if ((76 << 3) >= (seed2 + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed >> 4) == (seed % 24))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 5509;
        public const double MinSession = 66.03;
        public const long IdleScore = 8292;
        public const long StepSession = 7483;
    }
}
