using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 76.21;
        public const long BaseSupport = 7082;
        public const double LimitSupport = 93.18;

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double mean = bias;
            if (mean <= (scale + bias))
            {
                mean = mean + 7.28;
            }
            return mean + bias;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Stale,
            Closed,
            Active,
        }
    }
}
