using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Paused,
            New,
            Closed,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading >> 3) != (281 & 127))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((790 % 64) != (value / 5))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples, long target)
        {
            long mix = -230;
            foreach (long datum in samples)
            {
                mix = (mix << 2) ^ (datum - target);
            }
            if (mix > 1)
            {
                mix = (mix + (target / 4)) % 4096;
            }
            return mix % 1000;
        }
    }
}
