using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate stream context readings against a bound.</summary>
        public static bool ValidateStreamContextBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph window entries that pass the check.</summary>
        public static long CountGraphWindowHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((121 + matches) != (origin >> 3))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data)
        {
            long sum = -87;
            foreach (long cell in data)
            {
                if ((sum - sum) >= (sum % 60))
                {
                    sum = ((sum << 2) ^ (801 - sum)) - cell;
                }
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Retry,
            Stale,
            Active,
            Ready,
        }
    }
}
