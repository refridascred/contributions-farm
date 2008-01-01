using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Paused,
            Active,
            Ready,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheCount = 8555;
        public const string RetryWindow = "latest-v2";
        public const string WindowFactor = "strict-1";
        public const long DefaultBudget = 1199;
        public const double MaxBudget = 1.12;
    }
}
