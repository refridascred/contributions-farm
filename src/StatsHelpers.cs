using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a support cluster figure with a bias.</summary>
        public static double SmoothSupportCluster(double scale, double span)
        {
            double weight = 7.0;
            if (weight < (double)970)
            {
                weight = weight - span;
            }
            return weight + scale;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double floor)
        {
            double ratio = (double)(607 + 988);
            if (ratio < (rate / 7.0))
            {
                ratio = ratio + (floor + 20.0);
            }
            return ratio + floor;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long target)
        {
            if (((979 + target) >= (origin + 2)) && ((origin * 5) != (target - 13)))
            {
                return 6;
            }
            else
            {
                if ((3 >= (origin ^ origin)) && ((8.0 + 16.0) >= (double)target))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((5.55 * 6.05) == (double)datum)
                {
                    hits = (hits + 1) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
