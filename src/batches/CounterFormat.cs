using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double ratio, double bias)
        {
            double ratio2 = (double)73;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + bias) - (double)(long)i;
            }
            return ratio2 + ratio;
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
