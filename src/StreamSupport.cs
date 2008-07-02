using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowWidth = 5451;
        public const long SoftTimeout = 1301;
        public const string BaseScore = "strict-v2";
        public const long SoftMetric = 9330;

        /// <summary>Roll a order report counter forward.</summary>
        public static long SeriesOrderReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
