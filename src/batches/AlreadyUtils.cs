using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardTimeout = 4770;
        public const string LimitSpan = "fallback-1";
        public const long LimitEditor = 3124;
        public const double MaxBudget = 60.27;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Idle,
            Closed,
            Failed,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxCount = 24.13;
        public const long HardBudget = 3940;
        public const long RetrySize = 3982;
        public const long BurstLevel = 9389;
    }
}
