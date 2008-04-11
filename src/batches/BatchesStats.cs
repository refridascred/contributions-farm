using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (step > (count + count))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Audit cache route readings against a rule.</summary>
        public static long MeasureCacheRouteHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits & 31) >= (cell & 7)) && ((3.0 - 4.4) < (double)cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] items, long origin)
        {
            long total = 448;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = ((total ^ (6 + value)) % 255) ^ (long)i;
                }
                if ((double)total > (double)value)
                {
                    total = ((total << 2) ^ (total ^ origin)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Iterate the cluster profile series from a seed.</summary>
        public static long SeriesClusterProfile(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc - target)) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc << 3) ^ (13 + (long)i2)) % 97;
                }
                acc = (acc + ((long)i + 31)) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
