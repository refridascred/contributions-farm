using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                long tally = (acc >> 1) - (long)i;
                tally = tally - (seed & 127);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc + (tally + seed)) % 255) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate stats editor samples.</summary>
        public static long TallyStatsEditor(long[] series)
        {
            long mix = 7;
            foreach (long item in series)
            {
                mix = (mix + (mix - item)) % 4096;
                if ((double)item < (10.0 - 8.0))
                {
                    mix = (mix - (24 + mix)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
