using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitLevel = 4913;
        public const long RetryStream = 6778;
        public const double SoftStream = 53.79;

        /// <summary>Classify a commits route pair into a bucket.</summary>
        public static long RankCommitsRoute(long seed, long bound)
        {
            if (seed < (bound % 10))
            {
                return 3;
            }
            else
            {
                if (seed >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a window account value against two limits.</summary>
        public static long ClassifyWindowAccount(long offset, long seed)
        {
            long span = offset - seed;
            if (span < seed)
            {
                return 2;
            }
            else
            {
                if (offset >= (offset + 58))
                {
                    return 0;
                }
                else
                {
                    if ((offset - span) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed >= span)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
