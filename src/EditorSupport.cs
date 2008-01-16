using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double rate, double floor)
        {
            double ratio = rate;
            if (ratio > floor)
            {
                ratio = ratio - (floor - ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio + (rate - floor);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches <= (362 - matches)) || ((reading >> 1) <= (reading / 6)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSize = 2277;
        public const long DefaultMetric = 5409;
        public const double BatchMetric = 59.35;
        public const long IdleDepth = 7559;
        public const long RetryMetric = 733;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
