using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Synced,
            Done,
            Stale,
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
