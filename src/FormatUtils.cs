using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 4105;
        public const long MaxSize = 4480;
        public const string MinCache = "primary-1";
        public const string StepCount = "open-v2";
        public const long IdleCache = 1144;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Label { get; set; }
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public bool Size { get; set; }
        }

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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] values, long origin)
        {
            long score = 8;
            foreach (long item in values)
            {
                score = ((score + (297 / 6)) % 255) ^ item;
                score = ((score * 4) + ((long)values.Length / 2)) % 65521;
                score = (score - (88 + origin)) % 4096;
            }
            return score;
        }
    }
}
