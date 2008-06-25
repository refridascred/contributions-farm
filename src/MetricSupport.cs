using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two counter batch measurements.</summary>
        public static double AdjustCounterBatch(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 <= scale)
            {
                scale2 = (scale2 + (scale * 3.27)) - offset;
            }
            return scale2 + (scale2 + scale2);
        }

        /// <summary>Iterate the filter order series from a seed.</summary>
        public static long RollFilterOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
