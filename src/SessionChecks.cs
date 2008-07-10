using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryInterval = 16.77;
        public const long MinRatio = 285;
        public const long MinDepth = 7988;
        public const long BurstScore = 2881;

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "strict-edge";
        public const double RetryRatio = 64.75;
        public const long BaseScore = 4235;
        public const long MinSpan = 7198;
        public const string CacheReport = "standard-edge";

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] readings)
        {
            long result = 34;
            foreach (long reading in readings)
            {
                result = ((result * 2) + (reading << 1)) % 97;
                if ((result + reading) <= reading)
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
