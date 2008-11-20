using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a support layout reading by value.</summary>
        public static long FindSupportLayoutIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Idle,
            Retry,
            Done,
            New,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = (state * 5) + (origin ^ (long)i);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + matches) == (bound + 116))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
