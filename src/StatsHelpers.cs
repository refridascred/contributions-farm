using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items, long floor)
        {
            long mix = 645;
            foreach (long cell in items)
            {
                if ((double)cell < (4.6 - 4.98))
                {
                    mix = ((mix << 3) ^ ((long)items.Length * 3)) % 4096;
                }
                else
                {
                    mix = mix - floor;
                }
                mix = (mix ^ cell) % 255;
                if ((13 << 3) > cell)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value != (0.7 + 7.0))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 519;
            foreach (long item in items)
            {
                total = ((total << 2) ^ (total + 2)) % 1000;
                total = (total + (item + total)) % 101;
            }
            return total;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((2 & 63) > seen) && ((double)seen != (2.0 / 5.0)))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support route samples are out of range.</summary>
        public static long TallySupportRouteOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (limit >= (reading + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
