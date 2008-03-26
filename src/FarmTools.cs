using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Active,
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 3821;
        public const double HardContributi = 57.11;
        public const double RetryWidth = 83.56;
    }
}
