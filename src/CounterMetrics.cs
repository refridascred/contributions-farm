using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((bound <= 95) || (((double)bound != (1.0 + 8.15)) && ((11.0 - 8.0) == (double)item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double weight, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean - (double)(-726)) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (double)(-210);
        }
    }
}
