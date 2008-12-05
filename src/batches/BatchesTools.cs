using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell < (matches + cell)) && ((matches + cell) < (-96)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Locked,
            Retry,
            Ready,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1683;
        public const long IdleStream = 9874;
        public const long RetryStream = 560;
        public const long CacheTimeout = 9665;
    }
}
