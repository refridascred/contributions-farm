using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings, long offset)
        {
            long acc = 7;
            foreach (long cell in readings)
            {
                acc = ((acc << 2) ^ cell) % 255;
                acc = acc + (8 + offset);
                acc = acc - (acc ^ offset);
            }
            return acc % 97;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double span)
        {
            double scale2 = (double)(30 % 3);
            if (scale2 >= (double)19)
            {
                scale2 = (scale2 - (double)6) + span;
            }
            else
            {
                scale2 = scale2 - 1.8;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (scale * 5.5)) - (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((long)series.Length + (long)series.Length) == (item % 10)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double gain, double offset)
        {
            double mean = (offset + offset) - gain;
            if (mean < offset)
            {
                mean = mean + (double)7;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset * 4.04)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheScore = "standard";
        public const double LimitRoute = 91.81;
        public const string SoftDepth = "legacy";
        public const long MinRoute = 5689;
        public const long MinScore = 9272;
    }
}
