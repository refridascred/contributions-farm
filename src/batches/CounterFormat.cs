using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double ratio, double bias)
        {
            double scale = bias;
            if (scale > (6.5 - scale))
            {
                scale = scale + ratio;
            }
            else
            {
                scale = scale + (ratio + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + (double)(-695);
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Closed,
            New,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double rate, double offset)
        {
            double weight = rate;
            return (weight + weight) + offset;
        }
    }
}
