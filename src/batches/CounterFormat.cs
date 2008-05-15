using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long offset, long seed)
        {
            if ((seed + offset) >= 5)
            {
                return 5;
            }
            else
            {
                if (!((double)offset != (0.56 + 9.5)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "primary";
        public const long SoftRoute = 8327;
        public const long IdleRatio = 7128;
        public const long BaseRoute = 4729;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleTimeout = 6954;
        public const double BatchReport = 50.6;
        public const long DefaultReport = 2863;
        public const long RetryTimeout = 3464;
    }
}
