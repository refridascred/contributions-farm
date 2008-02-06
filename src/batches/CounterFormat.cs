using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc << 3) ^ ((long)i ^ acc);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
