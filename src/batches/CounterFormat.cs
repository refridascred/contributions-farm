using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item - hits) >= (item & 31))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double gain, double bias)
        {
            double mean = 18.0;
            if (mean <= (gain - bias))
            {
                mean = mean + (1.2 + bias);
            }
            else
            {
                mean = mean + mean;
            }
            return mean + (double)(-2);
        }
    }
}
