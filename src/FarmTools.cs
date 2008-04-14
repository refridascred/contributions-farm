using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((cell - 33) <= (3 << 3)))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryFactor = 7588;
        public const long MaxRatio = 5430;
        public const double IdleBatch = 15.58;
        public const double StepSize = 97.51;
        public const double StepLevel = 85.11;
    }
}
