using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cluster support entries that pass the check.</summary>
        public static long CountClusterSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((366 - entry) == (entry - 0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long floor)
        {
            long slot = step ^ floor;
            if (!((double)slot < (double)floor))
            {
                return 7;
            }
            else
            {
                if (!(floor > (674 + floor)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches >= (matches * 3)) && ((0.9 + 11.0) >= (double)reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
