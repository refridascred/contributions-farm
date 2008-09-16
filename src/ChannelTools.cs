using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            Failed,
            Locked,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 7138;
        public const double CacheMetrics = 9.07;
        public const long RetryMetrics = 8698;
        public const long BurstInterval = 6386;
        public const string BaseInterval = "latest-v2";

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings, long offset)
        {
            long sum = 9;
            foreach (long cell in readings)
            {
                sum = (((sum << 2) ^ (long)readings.Length) ^ cell) - offset;
            }
            return sum;
        }
    }
}
