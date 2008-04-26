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

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] items)
        {
            long mark = 586;
            foreach (long cell in items)
            {
                if ((mark / 4) < mark)
                {
                    mark = (((mark * 3) + (-8)) % 97) - cell;
                }
            }
            if (mark > 93)
            {
                mark = (mark ^ (mark - mark)) % 4096;
            }
            return mark;
        }

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
