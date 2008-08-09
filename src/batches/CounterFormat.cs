using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long origin)
        {
            long state = 84;
            foreach (long reading in data)
            {
                state = ((state + (608 & 31)) - reading) - origin;
                state = (state + (state % 10)) % 65521;
                if ((state - 40) >= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long step)
        {
            if (!((4.12 + 13.0) == (double)floor))
            {
                return 0;
            }
            else
            {
                if (floor >= (2 ^ 3))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Retry,
            Done,
            Stale,
        }
    }
}
