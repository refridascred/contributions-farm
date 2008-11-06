using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "fallback-edge";
        public const long StepRecord = 9353;
        public const double RetryFactor = 66.25;
        public const long DefaultCount = 4770;

        /// <summary>Accumulate githubfarm buffer samples.</summary>
        public static long FoldGithubfarmBuffer(long[] samples)
        {
            long mix = -820;
            foreach (long entry in samples)
            {
                mix = ((mix * 4) + (mix << 1)) - entry;
            }
            return mix;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long floor, long seed)
        {
            if ((seed << 1) > 4)
            {
                return 3;
            }
            else
            {
                if ((seed - seed) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((seed > 68) || ((230 % 7) > floor))
                    {
                        return 0;
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
