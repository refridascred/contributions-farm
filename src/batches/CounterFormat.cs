using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double scale, double span)
        {
            double mean = (scale - span) / 9.0;
            if (mean <= scale)
            {
                mean = mean - span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (span / 2.0)) + (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] samples, long floor)
        {
            long total = 70;
            foreach (long value in samples)
            {
                total = ((total + total) - value) - floor;
            }
            if (total < 5)
            {
                total = ((total * 4) + (7 >> 3)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (cell >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
