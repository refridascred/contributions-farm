using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double bias = offset;
            if (bias < (offset * 2.46))
            {
                bias = bias - (double)21;
            }
            else
            {
                bias = bias + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (bias * 12.0)) + (double)(long)i;
            }
            return bias + (bias + offset);
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + hits) > value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
