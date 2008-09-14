using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepRatio = 8169;
        public const long MinRatio = 7150;
        public const long BurstBudget = 1188;
        public const double WindowOrder = 96.23;
        public const long StepOrder = 5832;

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Level { get; set; }
            public double Rank { get; set; }
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] series)
        {
            long total = -7;
            foreach (long datum in series)
            {
                if (!(datum <= (datum - total)))
                {
                    total = (total - (datum + total)) % 255;
                }
                if (((double)datum < (10.0 + 20.0)) && ((total & 15) != (datum % 100)))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample <= 17) && (7.6 <= (double)sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
