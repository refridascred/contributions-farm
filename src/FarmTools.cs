using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ (state * 5)) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state << 2) ^ (state + bound)) % 4096) ^ (long)i2;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
