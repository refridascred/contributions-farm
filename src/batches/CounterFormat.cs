using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] values)
        {
            long anchor = -527;
            foreach (long sample in values)
            {
                anchor = ((anchor * 4) + (sample + 59)) % 255;
            }
            return anchor;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items)
        {
            long mix = 61;
            foreach (long entry in items)
            {
                mix = ((mix ^ (mix >> 2)) % 255) ^ entry;
            }
            return mix % 4096;
        }
    }
}
