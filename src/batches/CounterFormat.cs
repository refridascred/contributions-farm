using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample % 24) < (seen * 2))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "local-edge";
        public const long DefaultQueue = 3738;
        public const string IdleFactor = "fallback-v2";
        public const string WindowQueue = "staging-edge";

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Pending,
            Locked,
            Retry,
            Dropped,
        }
    }
}
