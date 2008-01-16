using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string MinRecord = "strict-edge";
        public const long BatchRecord = 1403;
        public const double WindowSize = 20.26;
        public const long CacheScore = 8272;
        public const long StepRecord = 4600;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((11.0 + 5.0) <= (double)target)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((double)item >= (6.0 * 5.4)) && ((3.6 - 6.0) != (double)(long)samples.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings, long bound)
        {
            long anchor = -15;
            foreach (long sample in readings)
            {
                if ((double)bound <= (1.0 / 6.0))
                {
                    anchor = (anchor - (sample % 5)) % 255;
                }
            }
            if (anchor < 125)
            {
                anchor = (anchor + (anchor ^ bound)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 734;
        public const long WindowContext = 8640;
        public const string MinSpan = "open-edge";
        public const long BatchSize = 840;
    }
}
