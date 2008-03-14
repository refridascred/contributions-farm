using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value >> 3) >= (count % 5))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Adjust a editor buffer reading.</summary>
        public static double SmoothEditorBuffer(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < (ratio / 4.0))
            {
                ratio = (ratio + ratio) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - floor) - (double)(long)i;
            }
            return ratio - floor;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
