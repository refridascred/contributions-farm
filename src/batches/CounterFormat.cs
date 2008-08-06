using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double ratio, double floor)
        {
            double weight = (double)5;
            if (weight >= floor)
            {
                weight = (weight + 4.0) - ratio;
            }
            return weight + (floor + floor);
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Grade a stream cluster value against two limits.</summary>
        public static long BucketStreamCluster(long origin, long floor)
        {
            if ((double)origin > (9.74 / 5.0))
            {
                return 2;
            }
            else
            {
                if ((floor + floor) != (floor + 79))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
