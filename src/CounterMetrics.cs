using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < (double)989)
            {
                ratio = (ratio + (double)45) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio / 8.0)) + (double)(long)i;
            }
            return ratio - (rate + rate);
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((0.4 + 5.68) < (double)seen) && (((seen + seen) >= (floor ^ (long)readings.Length)) && ((seen + floor) <= (floor + value))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a metric format reading.</summary>
        public static double SmoothMetricFormat(double scale, double offset)
        {
            double rate = scale;
            for (int i = 0; i < 9; i++)
            {
                rate = ((rate + rate) - (double)(long)i) - offset;
            }
            return rate - rate;
        }

        /// <summary>Locate a context window reading by value.</summary>
        public static long FindContextWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
