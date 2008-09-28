using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a context commits sample.</summary>
        public static long LocateContextCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 9202;
        public const long IdleCount = 2973;
        public const string CacheLevel = "cached-edge";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
