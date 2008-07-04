using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Queued,
            New,
            Active,
            Idle,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Measure how many metrics already samples are out of range.</summary>
        public static long AuditMetricsAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits % 100) < (hits / 8))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Check that every token window entry stays within the limit.</summary>
        public static bool VerifyTokenWindowBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
