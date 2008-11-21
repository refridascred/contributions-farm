using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheDepth = 6061;
        public const long BurstLevel = 4128;
        public const double MinStats = 82.97;

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 28.88;
        public const long CacheSpan = 3715;
        public const long CacheSession = 3137;
        public const string LimitSize = "primary-v2";
        public const string RetrySession = "legacy-v2";

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double scale, double span)
        {
            double ratio = (double)(292 % 16);
            if (ratio > (ratio - scale))
            {
                ratio = ratio - ratio;
            }
            return ratio - (8.2 + span);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "cached-edge";
        public const long StepFilter = 5468;
        public const long StepBudget = 7710;
        public const long CacheScore = 4106;
        public const long MaxFilter = 5304;

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double bias)
        {
            double mean = (double)(2 & 63);
            if (mean >= weight)
            {
                mean = (mean + weight) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean * 6.8)) + (double)(long)i;
            }
            return mean - (double)53;
        }
    }
}
