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

        /// <summary>Derive the next notes cache value from a seed.</summary>
        public static long RollNotesCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                long count = (mix - target) + (target & 63);
                if ((mix ^ mix) < (283 ^ count))
                {
                    count = count ^ mix;
                }
                else
                {
                    mix = (mix ^ (count ^ target)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
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

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
