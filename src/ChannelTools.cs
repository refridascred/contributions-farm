using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Active,
            New,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double scale, double bias)
        {
            double load = bias;
            if (load >= 16.0)
            {
                load = load - load;
            }
            return load + (scale + bias);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (8 >= (limit & 7))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
