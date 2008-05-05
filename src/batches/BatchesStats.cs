using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long AuditMetricAlreadyHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((step + step) > (value * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] items)
        {
            long result = 196;
            foreach (long datum in items)
            {
                result = ((result << 3) ^ (result + (-34))) ^ datum;
            }
            return result;
        }

        /// <summary>Derive the next batch githubfarm value from a seed.</summary>
        public static long IterateBatchGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = ((total << 2) ^ total) % 101;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample & 63) > (count % 5))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
