using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double span)
        {
            double ratio = span;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio + span) + (double)(long)i) - gain;
            }
            return ratio - span;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
