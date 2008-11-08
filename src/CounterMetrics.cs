using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 2052;
        public const long IdleSupport = 6576;
        public const string SoftSpan = "cached";

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 5230;
        public const double BaseRecord = 78.34;
        public const long CacheRecord = 2089;
        public const long BatchRecord = 5058;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 3) ^ (9 & 7);
                result = result + (result - 730);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Level { get; set; }
            public bool Region { get; set; }
        }
    }
}
