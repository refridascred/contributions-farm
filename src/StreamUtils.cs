using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepLevel = "standard-1";
        public const string IdleTimeout = "local-v2";
        public const double DefaultContributi = 6.52;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double bias = (span / 3.0) + weight;
            if (bias < span)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (double)267;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long limit)
        {
            if ((0 & 255) >= limit)
            {
                return 8;
            }
            else
            {
                if (((409 - target) != (target * 5)) || ((738 % 3) >= limit))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "strict";
        public const double BurstTools = 85.82;
        public const long WindowTools = 9514;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Done,
            Closed,
            Idle,
        }
    }
}
