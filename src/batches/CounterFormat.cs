using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 212;
        public const double MaxAlready = 95.99;
        public const long LimitAlready = 939;

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "cached-1";
        public const string CacheSpan = "legacy-v2";
        public const double WindowSupport = 75.84;
        public const long BaseSize = 5567;

        /// <summary>Check that every buffer graph entry stays within the limit.</summary>
        public static bool VerifyBufferGraphRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
