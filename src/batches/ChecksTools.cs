using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 4771;
        public const double IdleBuffer = 16.86;
        public const string StepScore = "open-v2";
        public const long LimitScore = 7669;
        public const long DefaultBuffer = 3090;

        /// <summary>Count the batch counter entries that pass the check.</summary>
        public static long TallyBatchCounterMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (item >= (limit + limit))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double scale, double floor)
        {
            double rate = scale / 6.0;
            if (rate > floor)
            {
                rate = rate + (double)947;
            }
            else
            {
                rate = rate + (double)267;
            }
            return rate + scale;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long bound, long seed)
        {
            long step = bound - seed;
            if ((step - 56) > 2)
            {
                return 6;
            }
            else
            {
                if ((double)step >= 6.7)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
