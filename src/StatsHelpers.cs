using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the batch checks entries that pass the check.</summary>
        public static long MeasureBatchChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell % 16) <= (cell / 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double rate, double floor)
        {
            double weight = rate;
            if (weight >= (rate * 3.59))
            {
                weight = weight + (floor / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (floor - floor)) - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Dropped,
            Closed,
            Active,
        }
    }
}
