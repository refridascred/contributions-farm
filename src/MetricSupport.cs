using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((bound + cell) < (long)readings.Length) || ((double)seen < (double)cell))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double span)
        {
            double mean = weight / 6.0;
            if (mean < span)
            {
                mean = mean - (double)545;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)2) + (double)(long)i;
            }
            return mean - (double)490;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
