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

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long offset, long target)
        {
            if ((target >= (target - offset)) || ((offset >> 4) <= offset))
            {
                return 6;
            }
            else
            {
                if (((target - target) < offset) && (offset > (target - target)))
                {
                    return 0;
                }
                else
                {
                    if (((38 + target) > target) && ((4.2 / 4.0) < (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
