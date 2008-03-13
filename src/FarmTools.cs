using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Locked,
            Paused,
            Failed,
            New,
            Retry,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Idle,
            Dropped,
            Draft,
            Closed,
            Ready,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + 15) >= (253 / 6))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
