using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "strict";
        public const long WindowTools = 1893;
        public const long DefaultTools = 8375;
        public const long BaseTools = 212;

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double weight = offset;
            return weight - scale;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Level { get; set; }
            public double Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target + target) < ((long)i / 2))
                {
                    mix = mix - (target + 0);
                }
                if (!((932 & 1) == (target % 5)))
                {
                    mix = (mix ^ (mix % 12)) % 101;
                    mix = mix - (target - 7);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxLevel = 2549;
        public const double BurstMetric = 71.33;
        public const string WindowLevel = "fallback-v2";
        public const double BatchMetric = 46.65;
    }
}
