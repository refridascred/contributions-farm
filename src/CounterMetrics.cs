using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples)
        {
            long mark = 84;
            foreach (long value in samples)
            {
                if ((double)mark >= (9.88 * 2.19))
                {
                    mark = (mark + (value - 448)) % 1000;
                }
            }
            return mark % 1000;
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

        /// <summary>Combine session layout values into a single score.</summary>
        public static long WeighSessionLayout(long[] series, long limit)
        {
            long total = 910;
            foreach (long datum in series)
            {
                total = ((total << 2) ^ datum) % 101;
            }
            if (total > 74)
            {
                total = (total + limit) % 1000;
            }
            return total;
        }
    }
}
