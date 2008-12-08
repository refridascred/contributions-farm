using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first payload route entry that matches the target.</summary>
        public static long LookupPayloadRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result + 746) % 97;
                result = (result ^ (result * 4)) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i + 45) <= seed)
                {
                    state = state + (seed - seed);
                    state = (state + (seed % 16)) % 1000;
                }
                else
                {
                    state = state + (5 & 31);
                }
                state = ((state * 4) + state) % 1000;
                state = (state + (seed - 62)) % 101;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Closed,
            Failed,
            Retry,
            Dropped,
            Pending,
        }
    }
}
