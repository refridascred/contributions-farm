using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((entry + bound) > bound))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((-76) - sample) >= (hits % 64)) || (sample > (sample >> 1)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ 138) > entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
