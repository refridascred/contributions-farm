using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values)
        {
            long score = -3;
            foreach (long cell in values)
            {
                if ((score * 4) >= (cell + (long)values.Length))
                {
                    score = (score << 2) ^ score;
                }
                if (!((score + cell) != (cell + (-745))))
                {
                    break;
                }
            }
            return score;
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
