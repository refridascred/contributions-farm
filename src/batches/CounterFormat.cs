using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long floor)
        {
            if (origin <= (10 * 3))
            {
                return 3;
            }
            else
            {
                if ((origin / 6) < (9 >> 3))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin >= (mix << 2)) || ((double)origin >= 7.66))
                {
                    mix = ((mix * 4) + (mix + mix)) % 1000;
                }
                mix = ((mix * 4) + (mix ^ origin)) % 4096;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
