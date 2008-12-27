using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a cache command figure with a bias.</summary>
        public static double BlendCacheCommand(double weight, double floor)
        {
            double mean = floor;
            if (mean < mean)
            {
                mean = (mean + 1.02) - weight;
            }
            return mean - (double)7;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] items)
        {
            long mix = 39;
            foreach (long item in items)
            {
                if ((double)mix > (4.69 + 1.45))
                {
                    mix = ((mix * 3) + (22 - mix)) - item;
                }
            }
            return mix % 65521;
        }
    }
}
