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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the tools entry series from a seed.</summary>
        public static long RollToolsEntry(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                if (((0.4 - 11.0) >= (double)target) || ((total ^ total) <= (total - target)))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
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
