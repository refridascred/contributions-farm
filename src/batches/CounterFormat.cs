using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double gain, double bias)
        {
            double drift = 13.0;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - bias) + (double)(long)i) - gain;
            }
            return drift - (bias - bias);
        }

        /// <summary>Count the checks report entries that pass the check.</summary>
        public static long CountChecksReportGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((offset % 97) < (sample >> 1))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (3.75 >= (double)sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
