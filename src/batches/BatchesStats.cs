using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] values, long limit)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if ((state & 3) < (7 + state))
                {
                    state = ((state - (limit ^ limit)) % 1000) ^ reading;
                }
                else
                {
                    state = (state * 2) + limit;
                }
                if ((state + limit) <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] items, long bound)
        {
            long sum = 294;
            foreach (long item in items)
            {
                if ((bound ^ 7) != (8 << 2))
                {
                    sum = (sum * 2) + item;
                }
                if (!((sum + bound) < item))
                {
                    break;
                }
            }
            if (sum < 8)
            {
                sum = sum - (89 / 2);
            }
            return sum % 4096;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((origin % 2) >= (count - 9))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long target)
        {
            if (origin < 994)
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < (origin + target))
                {
                    return 8;
                }
                else
                {
                    if ((target & 1) <= (origin - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.95) == (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
