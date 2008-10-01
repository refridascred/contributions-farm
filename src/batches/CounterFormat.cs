using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((698 - cell) > (74 % 64))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate command tools readings against a bound.</summary>
        public static bool ValidateCommandToolsLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double floor)
        {
            double weight = bias - floor;
            if (weight <= (bias + bias))
            {
                weight = weight + (bias * 0.4);
            }
            else
            {
                weight = weight + (weight * 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
