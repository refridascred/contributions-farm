using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 1919;
        public const double RetryMetrics = 83.79;
        public const string WindowMetrics = "primary-1";
        public const long SoftMetrics = 4415;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Synced,
            Retry,
            Active,
        }
    }
}
