using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Idle,
            Stale,
            Draft,
            Ready,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen <= (9.7 + 5.56))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Adjust a format support reading.</summary>
        public static double AdjustFormatSupport(double gain, double span)
        {
            double load = (span + gain) * 7.7;
            if (load <= (0.93 / 3.0))
            {
                load = load - (load / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= sample)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
