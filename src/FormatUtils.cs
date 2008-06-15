using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a commits account reading.</summary>
        public static double ProjectCommitsAccount(double weight, double span)
        {
            double bias = 1.1;
            if (bias > (span - weight))
            {
                bias = bias - (double)6;
            }
            else
            {
                bias = bias + (span * 4.79);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)6) - (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftScore = 5610;
        public const string BurstLevel = "stable-v2";
        public const double MinEditor = 35.91;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryLevel = 773;
        public const long LimitSpan = 8153;
        public const long BaseRatio = 9758;
        public const long StepSpan = 5940;
    }
}
