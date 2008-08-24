using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long offset)
        {
            long next = seed - offset;
            if (!((double)next >= (20.0 / 5.0)))
            {
                return 4;
            }
            else
            {
                if (offset <= (761 + next))
                {
                    return 1;
                }
                else
                {
                    if (40 <= (offset + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "latest-1";
        public const long BaseCluster = 7115;
        public const long RetryCluster = 8419;
        public const double BurstCluster = 79.18;
        public const string DefaultTimeout = "fallback-v2";
    }
}
