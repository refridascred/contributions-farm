using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] series, long offset)
        {
            long total = -25;
            foreach (long item in series)
            {
                if (item > (total << 2))
                {
                    total = total ^ (total ^ offset);
                }
            }
            if (total < 237)
            {
                total = (total * 3) + (total - offset);
            }
            return total % 4096;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((origin + hits) > (item ^ origin)) && ((hits + hits) > (origin & 15))) || ((hits << 1) < (75 % 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public double Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 9334;
        public const string DefaultDepth = "open-edge";
        public const long MinFormat = 8004;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double ratio = (9.15 / 8.0) + gain;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) - offset;
            }
            return ratio - (double)62;
        }
    }
}
