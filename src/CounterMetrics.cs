using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits < (hits - hits)) || (((hits / 4) >= (reading >> 4)) && ((offset << 1) <= (50 << 1))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Failed,
            Stale,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] series)
        {
            long total = 407;
            foreach (long cell in series)
            {
                total = (total - (cell ^ cell)) % 65521;
                if (!((638 >> 5) > (cell * 5)))
                {
                    total = (total ^ cell) % 4096;
                }
            }
            return total % 4096;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((3.0 * 1.03) < (double)sample) && (((92 - sample) >= 7) || (hits <= sample)))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
