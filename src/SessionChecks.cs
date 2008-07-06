using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!(sum >= (long)i))
                {
                    sum = ((sum * 4) + (sum - sum)) % 1000;
                    sum = (sum - limit) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "fallback-1";
        public const string WindowSize = "strict";
        public const string MaxWidth = "strict-v2";
        public const double CacheDepth = 18.97;

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Queued,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
