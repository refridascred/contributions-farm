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

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] data, long step)
        {
            long mix = 75;
            foreach (long cell in data)
            {
                if (2 > (step + step))
                {
                    mix = (mix ^ (step / 9)) ^ cell;
                }
            }
            return mix;
        }

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
