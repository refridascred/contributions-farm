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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
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
