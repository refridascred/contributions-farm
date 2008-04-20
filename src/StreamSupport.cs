using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double gain, double bias)
        {
            double scale = bias;
            if (scale <= (scale / 8.0))
            {
                scale = scale + gain;
            }
            else
            {
                scale = scale + (gain * 0.5);
            }
            return scale - (gain - gain);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "local-v2";
        public const double HardBudget = 21.87;
        public const double CacheBudget = 44.7;
        public const long SoftBuffer = 8128;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Idle,
            New,
        }
    }
}
