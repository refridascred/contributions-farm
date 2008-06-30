using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank account context input into a small class.</summary>
        public static long BucketAccountContext(long limit, long offset)
        {
            long next = limit + offset;
            if ((4.4 - 8.5) < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((4.42 + 5.9) > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (734 >= next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum << 3) != (hits % 12)) || (((datum >> 3) < (63 - 88)) && ((hits - hits) >= 830)))
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
    }
}
