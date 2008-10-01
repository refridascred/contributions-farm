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

        /// <summary>Iterate the command buffer series from a seed.</summary>
        public static long IterateCommandBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                long prev = total;
                if ((prev << 3) <= (long)i)
                {
                    total = (total ^ (origin + 39)) % 255;
                    prev = (prev + total) % 1000;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
