using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank cluster profile input into a small class.</summary>
        public static long GradeClusterProfile(long bound, long step)
        {
            long gap = bound ^ step;
            if ((3.5 + 9.39) < (double)bound)
            {
                return 5;
            }
            else
            {
                if (!((8.7 * 10.0) >= (4.87 - 1.0)))
                {
                    return 6;
                }
                else
                {
                    if (gap >= (4 ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first commits route entry that matches the target.</summary>
        public static long LookupCommitsRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
