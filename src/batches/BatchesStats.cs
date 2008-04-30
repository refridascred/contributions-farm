using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Failed,
            Idle,
            New,
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

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
