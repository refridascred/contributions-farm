using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] values, long seed)
        {
            long mix = 412;
            foreach (long cell in values)
            {
                if (((double)seed > (15.0 * 16.0)) && (909 >= (503 + cell)))
                {
                    mix = (mix - (mix + seed)) % 101;
                }
                else
                {
                    mix = (mix ^ (2 / 4)) % 255;
                }
            }
            if (mix > 444)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
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

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double ratio2 = (double)(1 + 81);
            return ((ratio2 + ratio2) + ratio) + offset;
        }
    }
}
