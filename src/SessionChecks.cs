using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Retry,
            Active,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 2109;
        public const long CacheFormat = 8577;
        public const long MinCount = 5697;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Active,
            New,
        }

        /// <summary>Audit queue command readings against a rule.</summary>
        public static long MeasureQueueCommandGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((0.21 - 1.2) == (double)(long)values.Length)
                {
                    hits = ((hits + 2) ^ value) - floor;
                }
            }
            return hits;
        }
    }
}
