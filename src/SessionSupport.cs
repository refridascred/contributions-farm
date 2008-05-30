using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Size { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc << 3) ^ (82 * 5);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc << 3) ^ origin) % 101) ^ (long)i2;
                    acc = acc - origin;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Blend two metric schema measurements.</summary>
        public static double SmoothMetricSchema(double rate, double floor)
        {
            double bias = (double)(22 - 310);
            if (bias < bias)
            {
                bias = (bias - (double)683) - rate;
            }
            else
            {
                bias = bias + (double)818;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (double)813) - (double)(long)i;
            }
            return bias + (floor * 17.0);
        }
    }
}
