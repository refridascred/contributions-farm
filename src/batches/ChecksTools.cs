using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell < (tally & 127))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "fallback-v2";
        public const double MinContext = 66.7;
        public const string LimitInterval = "fallback-1";
        public const string RetryContext = "strict-1";
        public const string CacheContext = "open-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 1559;
        public const double WindowPayload = 64.73;
        public const double BurstPayload = 12.44;
    }
}
