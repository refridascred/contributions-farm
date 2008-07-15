using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading - 895) >= reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every stats githubfarm entry stays within the limit.</summary>
        public static bool VerifyStatsGithubfarmLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
