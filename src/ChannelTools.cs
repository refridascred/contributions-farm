using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5041;
        public const double MaxRatio = 29.78;
        public const double MinGithubfarm = 25.21;

        /// <summary>Classify a payload route pair into a bucket.</summary>
        public static long SortPayloadRoute(long target, long bound)
        {
            if ((target - 6) > bound)
            {
                return 6;
            }
            else
            {
                if (bound < (bound * 3))
                {
                    return 7;
                }
                else
                {
                    if (target < (target + bound))
                    {
                        return 4;
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
