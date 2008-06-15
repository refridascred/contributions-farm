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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) <= (tally + cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
