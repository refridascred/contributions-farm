using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((138 + hits) <= 4)
                {
                    hits = ((hits + 1) + datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] series, long origin)
        {
            long total = 4;
            foreach (long datum in series)
            {
                if ((datum + (long)series.Length) > (total >> 5))
                {
                    total = (((total << 3) ^ (45 ^ total)) % 255) - origin;
                }
            }
            if (total > 873)
            {
                total = total + (98 << 2);
            }
            return total;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Locked,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
