using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 5355;
        public const long SoftFactor = 1511;
        public const long MaxDepth = 6181;

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "fallback-v2";
        public const long DefaultReport = 5042;
        public const double LimitCount = 42.98;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
