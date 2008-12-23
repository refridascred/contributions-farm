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

        /// <summary>Count order tools pairs that satisfy a relation.</summary>
        public static long MatchOrderToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
