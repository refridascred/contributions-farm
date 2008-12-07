using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long limit, long offset)
        {
            long slot = limit + offset;
            if (!(slot >= 31))
            {
                return 7;
            }
            else
            {
                if (((double)offset < (6.0 * 6.4)) || ((slot & 3) > (slot << 2)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 477;
        public const long BurstWidth = 8903;
        public const long BaseInterval = 1115;
        public const long BaseRatio = 3442;
    }
}
