using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double load = (offset - 8.2) - offset;
            if (load >= (weight * 6.84))
            {
                load = load + load;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (weight + load);
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
