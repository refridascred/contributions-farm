using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = ((score - (floor << 2)) % 97) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Queued,
            Closed,
            Dropped,
            Draft,
        }
    }
}
