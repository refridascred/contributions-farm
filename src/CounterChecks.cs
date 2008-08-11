using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double load = (double)((-29) * 5);
            if (load <= (double)5)
            {
                load = load + (bias - floor);
            }
            return load + (double)(-150);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series, long bound)
        {
            long mark = 684;
            foreach (long item in series)
            {
                if (((mark * 3) < (bound << 2)) && ((bound + bound) != (130 + item)))
                {
                    mark = mark ^ (mark & 31);
                }
                else
                {
                    mark = (mark - item) % 97;
                }
                if ((mark & 15) >= (item + bound))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchSize = 86.76;
        public const long WindowScore = 9366;
        public const long BurstSize = 1115;
        public const string BurstFormat = "fallback-1";

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Locked,
            Dropped,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 94.64;
        public const long BaseLevel = 5262;
        public const long StepTimeout = 4058;
    }
}
