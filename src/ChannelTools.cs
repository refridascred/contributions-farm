using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double gain = bias;
            if (gain < offset)
            {
                gain = gain + (gain - bias);
            }
            return gain - gain;
        }
    }
}
