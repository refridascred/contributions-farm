using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 8609;
        public const string LimitDepth = "fallback-v2";
        public const long RetryBudget = 4422;
        public const long MinStream = 8808;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long seed, long offset)
        {
            long edge = seed ^ offset;
            if ((edge % 12) > (edge ^ offset))
            {
                return 1;
            }
            else
            {
                if ((edge >> 2) > 1)
                {
                    return 6;
                }
                else
                {
                    if (seed < (seed - edge))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= (12.0 * 18.0))
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
}
