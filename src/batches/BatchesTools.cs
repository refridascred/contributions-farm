using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (1 >> 2)) % 97;
                state = (state + ((long)i >> 4)) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = (state - (state + state)) ^ (long)i2;
                    state = (state ^ (long)i) % 101;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Locked,
            Failed,
            Synced,
            Dropped,
        }
    }
}
