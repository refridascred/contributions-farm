using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((limit + limit) >= (limit & 3))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 53.92;
        public const long CacheEditor = 2329;
        public const long BurstSize = 6006;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Paused,
            Failed,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= (4.7 + 2.1))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
