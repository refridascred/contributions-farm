using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit metrics editor readings against a rule.</summary>
        public static long TallyMetricsEditorMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((step << 2) > seen)
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchWidth = 4323;
        public const string BatchDepth = "stable-v2";
        public const long IdleBudget = 5276;
        public const string IdleDepth = "latest-1";
        public const long RetryQueue = 779;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Closed,
            Failed,
            Active,
            Done,
            Synced,
        }
    }
}
