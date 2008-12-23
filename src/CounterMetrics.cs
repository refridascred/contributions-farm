using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a cluster buffer reading.</summary>
        public static double ScaleClusterBuffer(double scale, double floor)
        {
            double load = scale - (scale + floor);
            if (load >= (floor + floor))
            {
                load = load + (scale + floor);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (2.51 - scale)) + (double)(long)i;
            }
            return load - (double)(-499);
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double weight, double offset)
        {
            double scale = 8.0;
            if (scale >= (scale + 5.2))
            {
                scale = ((scale - (scale * 2.3)) - weight) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + 16.0) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double weight = floor;
            if (weight > (floor * 7.89))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + (gain * 0.5);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight - (double)35;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
