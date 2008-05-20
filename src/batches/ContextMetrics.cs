using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((seed + reading) == (seed / 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits <= (hits / 2)) || (((9 + datum) == (0 + hits)) && ((double)datum <= (8.85 / 5.0))))
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

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits << 1) <= cell) && ((double)hits != (1.6 * 7.3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
