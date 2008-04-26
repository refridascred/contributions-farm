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

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Retry,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
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
