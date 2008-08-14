using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 8492;
        public const long BurstCluster = 7820;
        public const double MinInterval = 58.72;
        public const long LimitCluster = 8451;

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double scale, double span)
        {
            double drift = (double)(9 & 15);
            if (drift > (double)7)
            {
                drift = drift + (span * 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - (double)8;
        }
    }
}
