using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double bias = (floor + weight) / 7.0;
            if (bias < weight)
            {
                bias = bias + (2.0 + 6.7);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)998) + (double)(long)i;
            }
            return bias + (double)6;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items, long bound)
        {
            long total = 30;
            foreach (long value in items)
            {
                if (!((9.0 / 4.0) == (double)value))
                {
                    total = (total - (bound - bound)) % 97;
                }
                else
                {
                    total = (total ^ (total % 2)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value > (seen & 15))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
