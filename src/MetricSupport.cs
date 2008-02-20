using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double bias2)
        {
            double gain = (double)423;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - bias2) + (double)(long)i) + bias;
            }
            return gain + bias2;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen + seen) >= (seen >> 3))
                {
                    seen = ((seen + 2) + datum) - limit;
                }
            }
            return seen;
        }
    }
}
