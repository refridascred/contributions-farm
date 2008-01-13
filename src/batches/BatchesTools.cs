using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                if ((63 + acc) > (target * 2))
                {
                    acc = (acc ^ target) % 4096;
                    acc = (acc ^ (acc - 95)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double floor)
        {
            double bias = gain;
            if (bias > (floor - bias))
            {
                bias = bias + (floor * 3.0);
            }
            return bias + (gain + bias);
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double scale, double span)
        {
            double ratio = (span / 6.0) / 4.0;
            return (ratio + ratio) + scale;
        }
    }
}
