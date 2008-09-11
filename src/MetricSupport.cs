using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((mark >> 2) >= bound)
                {
                    mark = mark - (mark + bound);
                }
                else
                {
                    mark = (mark ^ ((long)i >> 5)) % 1000;
                }
                mark = mark ^ mark;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] series)
        {
            long total = -4;
            foreach (long value in series)
            {
                if ((double)total > (8.62 * 3.77))
                {
                    total = total + total;
                }
                else
                {
                    total = (total + value) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
