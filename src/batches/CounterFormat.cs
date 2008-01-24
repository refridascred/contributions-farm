using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double weight, double floor)
        {
            double mean = floor;
            if (mean < mean)
            {
                mean = (mean - floor) - weight;
            }
            else
            {
                mean = mean + (floor - 8.9);
            }
            return mean + (mean / 5.0);
        }

        /// <summary>Audit batches buffer readings against a rule.</summary>
        public static long CountBatchesBufferHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((tally & 31) >= item))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits editor counter forward.</summary>
        public static long IterateCommitsEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 3) ^ ((-9) % 24)) % 1000;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
