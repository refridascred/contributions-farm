using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Dropped,
            Draft,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) > limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((floor > ((long)i << 2)) || ((floor + 812) <= (total + floor)))
                {
                    total = ((total << 3) ^ (long)i) % 4096;
                }
                else
                {
                    total = (total << 2) ^ ((long)i * 5);
                }
                total = (total + (floor >> 3)) % 255;
                total = total - (44 + (long)i);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((seed & 63) < (reading - reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
