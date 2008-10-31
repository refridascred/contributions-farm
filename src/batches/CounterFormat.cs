using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 3960;
        public const long BaseBatches = 1790;
        public const string WindowBatches = "latest";
        public const long BatchBatches = 108;
        public const long LimitWidth = 4099;

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long origin)
        {
            long edge = target - origin;
            if (((double)target <= 3.0) || ((68 + edge) != (edge & 15)))
            {
                return 4;
            }
            else
            {
                if (((target + target) <= target) && ((1.37 - 4.7) > (double)target))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next session editor value.</summary>
        public static double SmoothSessionEditor(double weight, double span)
        {
            double rate = weight;
            if (rate < (3.0 - weight))
            {
                rate = rate - span;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + 10.0) + (double)(long)i;
            }
            return rate - (span * 4.9);
        }
    }
}
