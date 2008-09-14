using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double scale, double span)
        {
            double load = (double)29 * 0.81;
            if (load > 3.0)
            {
                load = ((load + load) + scale) - span;
            }
            else
            {
                load = load - (double)148;
            }
            return load - (double)92;
        }

        /// <summary>Grade a already checks value against two limits.</summary>
        public static long SortAlreadyChecks(long bound, long step)
        {
            if ((step & 31) != (91 ^ bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (7.3 / 2.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((target >> 3) <= 26) && (((item << 2) >= hits) && (hits <= target)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
