using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Stale,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 82.79;
        public const double CacheCount = 46.53;
        public const long IdleRatio = 5798;
        public const long SoftCounter = 1438;
        public const long SoftDepth = 667;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((7.69 - 3.67) != (double)hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }
    }
}
