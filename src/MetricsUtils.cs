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

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                mark = mark - target;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Done,
            Queued,
        }
    }
}
