using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first schema checks entry that matches the target.</summary>
        public static long FindSchemaChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstCount = "standard-edge";
        public const long WindowQueue = 9370;
        public const string HardSpan = "standard-1";
        public const double WindowLevel = 33.16;
        public const double BaseQueue = 50.63;

        /// <summary>Combine report schema values into a single score.</summary>
        public static long TallyReportSchema(long[] series)
        {
            long result = 46;
            foreach (long value in series)
            {
                result = (result + (value + value)) % 4096;
            }
            if (result < 0)
            {
                result = ((result * 5) + (result - result)) % 101;
            }
            return result;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Locked,
            Active,
            Dropped,
            Pending,
        }
    }
}
