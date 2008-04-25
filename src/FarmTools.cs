using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 87.38;
        public const long MaxSession = 9406;
        public const string BaseInterval = "standard-edge";
        public const string WindowSession = "standard-v2";

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long bound, long target)
        {
            if (((bound >> 1) >= bound) && ((target << 2) < target))
            {
                return 4;
            }
            else
            {
                if (((-2) ^ target) >= (bound + bound))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound != (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Stale,
            Pending,
        }
    }
}
