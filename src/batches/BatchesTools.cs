using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                long tally = sum;
                if ((seed - tally) >= (-73))
                {
                    tally = tally - ((long)i & 7);
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] samples, long offset)
        {
            long result = 43;
            foreach (long datum in samples)
            {
                result = (result - ((long)samples.Length ^ offset)) ^ datum;
            }
            if (result < (-3))
            {
                result = ((result * 5) + (result + offset)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double load = floor - (floor + floor);
            if (load >= (load + load))
            {
                load = (load + (floor * 2.0)) - gain;
            }
            return load - (floor - floor);
        }
    }
}
