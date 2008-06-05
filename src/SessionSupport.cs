using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 341;
        public const long BurstRecord = 4801;
        public const double CacheRecord = 81.56;
        public const long WindowRecord = 1381;
        public const double MinLevel = 19.08;

        /// <summary>Scale a payload cluster figure with a bias.</summary>
        public static double SmoothPayloadCluster(double rate, double floor)
        {
            double ratio = rate;
            if (ratio >= (5.15 + floor))
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)74) - (double)(long)i;
            }
            return ratio + 4.58;
        }
    }
}
