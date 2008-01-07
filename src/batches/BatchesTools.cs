using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - (double)8) - (double)(long)i) + bias;
            }
            return load + (3.6 + 7.66);
        }
    }
}
