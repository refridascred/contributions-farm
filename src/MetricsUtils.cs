using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long offset, long seed)
        {
            if (((double)431 <= (double)seed) || (offset >= (629 + offset)))
            {
                return 1;
            }
            else
            {
                if (!(seed < offset))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long floor2)
        {
            long lane = floor ^ floor2;
            if (!((floor / 9) >= 2))
            {
                return 5;
            }
            else
            {
                if ((4.0 + 1.44) == (double)lane)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Done,
            Retry,
            Idle,
            New,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if (!((total > origin) || ((long)i <= (18 ^ origin))))
                {
                    total = (total << 3) ^ (origin + origin);
                }
                total = ((total << 3) ^ ((long)i ^ 222)) % 97;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a command record pair into a bucket.</summary>
        public static long ClassifyCommandRecord(long target, long limit)
        {
            long diff = target - limit;
            if (diff < (398 + diff))
            {
                return 5;
            }
            else
            {
                if (target < limit)
                {
                    return 7;
                }
                else
                {
                    if ((target >= (limit & 15)) && ((75 - limit) <= (limit & 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff / 9) == (limit + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
