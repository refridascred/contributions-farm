using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Score { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 <= (double)87)
            {
                weight2 = weight2 - (double)8;
            }
            else
            {
                weight2 = weight2 + (bias / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + (double)8) + (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long offset, long offset2)
        {
            if ((offset <= (offset2 - offset)) && ((double)offset2 >= (18.0 * 1.0)))
            {
                return 7;
            }
            else
            {
                if (offset2 > (offset2 * 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double load = (weight / 9.0) * 2.9;
            return (load - load) + offset;
        }
    }
}
