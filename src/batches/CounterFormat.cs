using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((bound - hits) != (datum / 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double bias, double offset)
        {
            double load = 7.0;
            if (load > (2.67 + load))
            {
                load = load - bias;
            }
            else
            {
                load = load + (double)346;
            }
            return load + (bias + offset);
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((limit ^ item) <= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
