using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Accumulate contributi cluster samples.</summary>
        public static long TallyContributiCluster(long[] items, long limit)
        {
            long state = 838;
            foreach (long entry in items)
            {
                state = state + (430 & 63);
                state = ((state << 2) ^ (state - entry)) % 1000;
                if ((7.2 + 4.0) != (double)limit)
                {
                    state = (state ^ (limit + entry)) % 97;
                }
                if ((state < (state + limit)) || ((entry & 31) >= (entry * 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
