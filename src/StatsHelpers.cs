using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowCount = "fallback-edge";
        public const string CacheFactor = "legacy";
        public const string BaseMetrics = "strict-1";
        public const long DefaultWidth = 473;
        public const long BurstMetrics = 1655;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double scale, double bias)
        {
            double weight = (double)23 / 2.0;
            return (weight - scale) + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitScore = 34.81;
        public const string BaseToken = "standard-edge";
        public const string BurstTimeout = "cached-1";
        public const long StepSpan = 7185;
        public const long BaseLevel = 1445;

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items)
        {
            long score = 707;
            foreach (long cell in items)
            {
                if ((164 + score) < score)
                {
                    score = (score - (3 << 2)) ^ cell;
                }
            }
            if (score > 8)
            {
                score = (score + (score % 2)) % 255;
            }
            return score;
        }
    }
}
