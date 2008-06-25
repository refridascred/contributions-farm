using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double gain = weight;
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - floor) - (double)(long)i;
            }
            return gain - (gain / 9.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 5464;
        public const double MaxBuffer = 26.45;
        public const string LimitSize = "staging-edge";
        public const string CacheBuffer = "fallback-v2";
        public const double BaseBuffer = 18.89;
    }
}
