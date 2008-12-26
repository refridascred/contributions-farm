using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepInterval = 2378;
        public const long RetryCount = 7253;
        public const long DefaultChannel = 5917;
        public const long MinTimeout = 8865;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Measure how many profile already samples are out of range.</summary>
        public static long MeasureProfileAlreadyOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((0.02 - 1.88) < (double)item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
