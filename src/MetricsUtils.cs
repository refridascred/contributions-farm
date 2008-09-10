using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits >> 2) <= (step - value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] data)
        {
            long score = 471;
            foreach (long entry in data)
            {
                score = (score - (score - score)) % 4096;
                score = ((score * 5) + (entry ^ score)) % 97;
                score = ((score * 3) + (entry >> 5)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "standard";
        public const double BatchSpan = 69.61;
        public const long RetryDepth = 2775;
        public const long BaseToken = 6547;
        public const long LimitCount = 1571;

        /// <summary>Scale a command context figure with a bias.</summary>
        public static double ProjectCommandContext(double gain, double span)
        {
            double rate = (double)75 - span;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (span / 3.0)) - (double)(long)i) + gain;
            }
            return rate + rate;
        }
    }
}
