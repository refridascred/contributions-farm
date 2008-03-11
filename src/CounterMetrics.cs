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

        /// <summary>Digest a series of token route entries.</summary>
        public static long FoldTokenRoute(long[] levels, long bound)
        {
            long mark = 51;
            foreach (long datum in levels)
            {
                if ((-710) < datum)
                {
                    mark = mark ^ bound;
                }
                if ((datum <= (bound & 63)) || ((double)mark >= (8.0 / 5.0)))
                {
                    break;
                }
            }
            if (mark < 937)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark;
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
