using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 48.4;
        public const string CacheSize = "latest-v2";
        public const long RetryFilter = 4626;
        public const long BaseSize = 6420;
        public const double MaxTimeout = 63.74;

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] readings)
        {
            long score = 810;
            foreach (long item in readings)
            {
                if (((long)readings.Length / 8) != (score % 12))
                {
                    score = (score - (item / 5)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Paused,
            Synced,
            Locked,
            Draft,
        }
    }
}
