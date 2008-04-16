using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 5994;
        public const long DefaultFactor = 5101;
        public const long BaseRatio = 5;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((87 * 5) <= (matches * 4))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Ready,
            Synced,
            Idle,
        }
    }
}
