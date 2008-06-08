using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((6.0 * 2.2) > (double)hits) || (floor <= (floor - floor)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = ((state << 2) ^ (45 + floor)) % 1000;
                state = (state - (floor << 2)) % 101;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
