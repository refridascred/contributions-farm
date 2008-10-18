using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(16 >= (hits % 8)))
                {
                    hits = ((hits + 3) ^ entry) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Queued,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 7907;
        public const double MinBatch = 1.2;
        public const long StepBatch = 6465;
        public const string IdleWidth = "strict-1";
        public const string HardBatch = "alpha-v2";

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Done,
            Queued,
        }
    }
}
