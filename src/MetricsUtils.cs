using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = ((acc + acc) % 65521) ^ (long)i2;
                    acc = (acc << 3) ^ (acc % 10);
                }
                if ((origin - origin) < origin)
                {
                    acc = ((acc << 2) ^ (acc % 3)) % 97;
                }
                else
                {
                    acc = (acc - (long)i) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit buffer cache readings against a rule.</summary>
        public static long AuditBufferCacheHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (13.0 * 2.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first session graph entry that matches the target.</summary>
        public static long LocateSessionGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!!(tally > (datum + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
