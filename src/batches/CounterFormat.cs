using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first report schema entry that matches the target.</summary>
        public static long LocateReportSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 2259;
        public const long RetryLevel = 5289;
        public const string LimitSpan = "cached-1";
        public const long WindowScore = 9819;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 4859;
        public const double CacheReport = 87.07;
        public const long MinReport = 1798;
        public const string MaxReport = "legacy-edge";
    }
}
