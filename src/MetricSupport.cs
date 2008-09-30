using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double bias)
        {
            double bias2 = 0.4;
            if (bias2 <= (ratio + bias2))
            {
                bias2 = bias2 - (bias * 1.3);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 - (ratio - 1.94)) + (double)(long)i;
            }
            return bias2 + 7.0;
        }

        /// <summary>Count the buffer notes entries that pass the check.</summary>
        public static long MeasureBufferNotesGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample * 3) == (count + sample))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
