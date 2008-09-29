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

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "cached-v2";
        public const string StepSchema = "strict";
        public const long IdleBudget = 503;
    }
}
