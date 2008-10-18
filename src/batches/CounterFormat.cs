using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                if (mix < (mix + mix))
                {
                    mix = (mix - (seed << 1)) % 65521;
                }
                mix = ((mix * 2) + ((long)i + mix)) % 97;
                if (!((seed & 255) <= 36))
                {
                    mix = (mix * 2) + mix;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
