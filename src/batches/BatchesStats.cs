using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits << 3) <= datum)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double rate = bias;
            return (rate - (rate / 3.0)) + weight;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitSize = 45.2;
        public const double RetryCommand = 71.59;
        public const long BaseCommand = 8578;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double rate = weight;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate + (weight / 7.0)) + (double)(long)i) - bias;
            }
            return rate - rate;
        }
    }
}
