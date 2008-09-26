using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                state = ((state << 2) ^ (seed % 24)) % 4096;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 4) + (state >> 3);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
