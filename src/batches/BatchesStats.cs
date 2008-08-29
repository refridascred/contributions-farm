using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] values)
        {
            long score = 506;
            foreach (long item in values)
            {
                score = ((score - score) % 65521) ^ item;
            }
            return score % 97;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (5.06 + 10.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstFactor = 43.2;
        public const long MaxDepth = 1936;
        public const long HardOrder = 641;
        public const long RetryOrder = 420;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Active,
            Dropped,
            Ready,
        }
    }
}
