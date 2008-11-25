using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 3.37;
        public const long RetryScore = 1081;
        public const long WindowLevel = 2394;
        public const long RetryFactor = 9655;

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }
    }
}
