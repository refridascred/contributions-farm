using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the window graph entries that pass the check.</summary>
        public static long AuditWindowGraphMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (2.39 + 1.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine account report values into a single score.</summary>
        public static long FoldAccountReport(long[] items, long origin)
        {
            long mark = 69;
            foreach (long reading in items)
            {
                if ((70 + mark) > (-6))
                {
                    mark = (mark - reading) + origin;
                }
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 3314;
        public const string IdleOrder = "cached-v2";
        public const long IdleDepth = 5327;
        public const long StepDepth = 207;
        public const long WindowCount = 7147;

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= (10.0 + floor))
            {
                bias2 = (bias2 - (bias2 - bias2)) + bias;
            }
            else
            {
                bias2 = bias2 + (double)99;
            }
            return bias2 - (floor / 9.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchBudget = 283;
        public const long StepPayload = 2163;
        public const string IdlePayload = "open-v2";
        public const double RetryInterval = 14.26;
    }
}
