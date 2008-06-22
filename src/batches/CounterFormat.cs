using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Synced,
            Ready,
            Pending,
            Stale,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long acc = 47;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc << 3) ^ (value / 4)) - (long)i;
                }
                if (((acc >> 5) > (value & 31)) || ((double)value < (4.0 / 9.0)))
                {
                    acc = ((acc << 2) ^ (acc - acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Audit cache support readings against a rule.</summary>
        public static long MeasureCacheSupportGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (0.1 <= (double)reading)
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
