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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
