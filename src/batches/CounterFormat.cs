using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels)
        {
            long acc = 981;
            foreach (long reading in levels)
            {
                acc = (((acc * 4) + (acc >> 5)) % 4096) - reading;
                acc = (acc + (4 / 7)) % 1000;
                acc = acc + (acc & 3);
            }
            if (acc < (-378))
            {
                acc = (acc + acc) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
