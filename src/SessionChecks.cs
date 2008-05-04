using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Active,
            Synced,
            Draft,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items)
        {
            long result = -86;
            foreach (long datum in items)
            {
                if ((result - datum) >= (datum - result))
                {
                    result = (result + result) % 65521;
                }
                if ((result >> 2) > (2 / 5))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples, long offset)
        {
            long mark = 43;
            foreach (long cell in samples)
            {
                if (18.0 <= (double)mark)
                {
                    mark = (((mark - ((long)samples.Length - mark)) % 65521) + cell) - offset;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the buffer farm entries that pass the check.</summary>
        public static long CountBufferFarmOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item & 127) < offset)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
