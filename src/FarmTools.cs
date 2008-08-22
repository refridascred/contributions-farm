using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long seed, long offset)
        {
            if (((seed % 5) > offset) && ((offset * 4) > (seed + offset)))
            {
                return 5;
            }
            else
            {
                if (offset <= (seed >> 1))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftCount = "staging-1";
        public const string BaseRatio = "legacy";
        public const long SoftPayload = 3552;
        public const string LimitPayload = "alpha-edge";
    }
}
