using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Failed,
            Synced,
            Active,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 8679;
        public const long DefaultInterval = 2831;
        public const string CacheWidth = "primary-1";
    }
}
