using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 3027;
        public const long LimitFactor = 1610;
        public const long MinProfile = 1639;
        public const double BatchProfile = 94.54;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Stale,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryLevel = 1408;
        public const double DefaultSession = 85.76;
        public const long CacheSession = 2311;

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Draft,
            Paused,
            Pending,
            Queued,
            Dropped,
        }
    }
}
