using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((5.9 - 0.4) >= (double)sample) || ((sample - sample) > (hits - 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((5.94 + 12.0) >= (double)matches)
                {
                    matches = ((matches + 2) ^ datum) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a buffer route pair into a bucket.</summary>
        public static long RankBufferRoute(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if ((7 + 1) >= floor)
            {
                return 7;
            }
            else
            {
                if (next <= (floor ^ next))
                {
                    return 8;
                }
                else
                {
                    if ((floor + next) <= (41 / 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
