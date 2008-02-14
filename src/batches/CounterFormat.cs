using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            New,
            Dropped,
            Active,
        }

        /// <summary>Count the order token entries that pass the check.</summary>
        public static long MeasureOrderTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((53 + seen) <= ((long)data.Length * 5))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
