using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double gain, double bias)
        {
            double drift = gain;
            if (drift < (double)16)
            {
                drift = drift + (drift - 2.0);
            }
            return drift - (drift - bias);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitLevel = 9972;
        public const string CacheBudget = "standard-edge";
        public const long LimitRecord = 5152;
        public const string BatchRecord = "legacy-1";
        public const long BurstInterval = 6552;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
