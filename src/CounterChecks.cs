using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Pending,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "primary-1";
        public const long BurstAccount = 7933;
        public const string BurstTimeout = "local-v2";

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already support readings against a bound.</summary>
        public static bool CheckAlreadySupportBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
