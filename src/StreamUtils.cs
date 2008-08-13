using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)offset != (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache context value against two limits.</summary>
        public static long ClassifyCacheContext(long floor, long limit)
        {
            if (((floor / 9) != (limit - 719)) && ((205 + floor) <= (7 + limit)))
            {
                return 4;
            }
            else
            {
                if (((limit * 2) < (floor * 2)) || ((142 - limit) < (21 - limit)))
                {
                    return 3;
                }
                else
                {
                    if (floor > (limit + floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.8 * 10.0) != (double)limit)
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

        /// <summary>Accumulate session profile samples.</summary>
        public static long DigestSessionProfile(long[] series)
        {
            long carry = 5;
            foreach (long item in series)
            {
                carry = (carry ^ (carry << 3)) - item;
            }
            return carry;
        }
    }
}
