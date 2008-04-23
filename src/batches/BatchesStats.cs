using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((8.8 / 5.0) == (double)datum))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches >= (2.87 - 2.86))
                {
                    matches = ((matches + 1) ^ datum) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series, long target)
        {
            long sum = 58;
            foreach (long reading in series)
            {
                sum = ((sum - (target << 1)) % 97) ^ reading;
                if (sum <= ((-2) % 100))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
