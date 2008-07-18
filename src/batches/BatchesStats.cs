using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit queue window readings against a rule.</summary>
        public static long CountQueueWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (28 <= (98 + (long)series.Length))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Idle,
            Locked,
            Active,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxInterval = 9236;
        public const double MaxWidth = 6.63;
        public const long RetryInterval = 3845;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
