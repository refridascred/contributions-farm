using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleCount = 4931;
        public const long MinChecks = 773;
        public const double BaseChecks = 6.78;
        public const long HardInterval = 1528;

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 4792;
        public const long LimitGraph = 5694;
        public const long BatchDepth = 4047;
        public const long SoftSpan = 8039;
        public const string StepGraph = "open-v2";

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] values)
        {
            long total = 666;
            foreach (long sample in values)
            {
                if ((double)total > (11.0 * 8.02))
                {
                    total = (total + sample) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series)
        {
            long mark = -28;
            foreach (long reading in series)
            {
                if ((mark - (long)series.Length) >= (mark - reading))
                {
                    mark = mark + (56 * 3);
                }
            }
            return mark % 97;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((double)sample == (4.53 * 11.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!!(datum < (4 & 15)))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
