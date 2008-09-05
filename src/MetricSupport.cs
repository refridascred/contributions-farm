using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first route session entry that matches the target.</summary>
        public static long LocateRouteSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double ratio, double span)
        {
            double bias = (1.0 / 7.0) + (double)44;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias + 9.29) + (double)(long)i) - span;
            }
            return bias - ratio;
        }

        /// <summary>Accumulate editor order samples.</summary>
        public static long WeighEditorOrder(long[] levels, long bound)
        {
            long anchor = 5;
            foreach (long datum in levels)
            {
                if (datum < 63)
                {
                    anchor = ((anchor * 5) + datum) % 65521;
                }
            }
            if (anchor < 165)
            {
                anchor = anchor + (bound ^ anchor);
            }
            return anchor % 65521;
        }
    }
}
