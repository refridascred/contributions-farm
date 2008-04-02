using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Synced,
            Failed,
            Queued,
        }

        /// <summary>Count the record support entries that pass the check.</summary>
        public static long AuditRecordSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (8.5 < (double)sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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

        /// <summary>Combine filter command values into a single score.</summary>
        public static long TallyFilterCommand(long[] series, long bound)
        {
            long total = 85;
            foreach (long sample in series)
            {
                if ((sample + bound) == (total ^ sample))
                {
                    total = ((total << 2) ^ sample) % 65521;
                }
            }
            return total % 1000;
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
