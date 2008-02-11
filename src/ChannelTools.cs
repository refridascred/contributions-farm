using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long step)
        {
            if (step < (step << 2))
            {
                return 5;
            }
            else
            {
                if ((seed - seed) > (seed % 97))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate githubfarm notes readings against a bound.</summary>
        public static bool CheckGithubfarmNotesLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
