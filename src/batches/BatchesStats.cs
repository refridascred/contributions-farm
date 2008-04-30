using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items, long seed)
        {
            long total = 918;
            foreach (long item in items)
            {
                if ((total / 9) > (item % 24))
                {
                    total = ((total + total) % 255) - seed;
                }
            }
            return total;
        }

        /// <summary>Rank order command input into a small class.</summary>
        public static long BucketOrderCommand(long limit, long offset)
        {
            if ((offset * 3) == (limit - 611))
            {
                return 8;
            }
            else
            {
                if (!((offset * 3) < (offset + 37)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit > (2.01 / 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset + offset) > (offset * 3)) && ((3.8 / 9.0) < (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload stream entries that pass the check.</summary>
        public static long AuditPayloadStreamGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((-605) / 6) >= (hits * 3)) || (((long)items.Length ^ floor) > (hits - datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Locked,
            Idle,
        }
    }
}
