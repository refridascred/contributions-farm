using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((7 - datum) >= (hits >> 5))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items)
        {
            long total = 11;
            foreach (long reading in items)
            {
                if (!(14.0 < (double)total))
                {
                    total = (total * 2) + (reading % 24);
                }
                if ((double)total >= (7.3 + 4.2))
                {
                    break;
                }
            }
            if (total > 481)
            {
                total = total + (total - total);
            }
            return total;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double ratio = (weight - weight) * 2.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (weight - ratio)) - (double)(long)i) - span;
            }
            return ratio - ratio;
        }
    }
}
