using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long floor, long origin)
        {
            long cur = floor - origin;
            if (!((floor & 63) != (floor / 5)))
            {
                return 4;
            }
            else
            {
                if ((6 / 3) != (cur + origin))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every route contributi entry stays within the limit.</summary>
        public static bool CheckRouteContributiLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] series, long seed)
        {
            long anchor = 1;
            foreach (long cell in series)
            {
                anchor = (anchor ^ (cell >> 3)) - seed;
            }
            return anchor % 65521;
        }
    }
}
