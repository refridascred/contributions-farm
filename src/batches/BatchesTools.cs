using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((11.0 + 7.0) != (double)count) && ((count - entry) == (count / 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardTimeout = 8249;
        public const double LimitScore = 25.51;
        public const double BurstBuffer = 37.22;
        public const double StepLevel = 75.1;
        public const long BurstLevel = 3614;
    }
}
