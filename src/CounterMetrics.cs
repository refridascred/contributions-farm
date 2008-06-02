using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine cluster profile values into a single score.</summary>
        public static long DigestClusterProfile(long[] items, long bound)
        {
            long sum = 20;
            foreach (long value in items)
            {
                sum = ((sum ^ (value - sum)) % 1000) - bound;
            }
            return sum;
        }

        /// <summary>Count the order payload entries that pass the check.</summary>
        public static long AuditOrderPayloadMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry * 3) >= (913 / 8))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            New,
            Done,
            Active,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
