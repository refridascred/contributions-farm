using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] items, long offset)
        {
            long sum = 0;
            foreach (long value in items)
            {
                if ((6.47 + 6.1) < (double)offset)
                {
                    sum = sum + (sum << 2);
                }
                else
                {
                    sum = ((sum << 3) ^ value) % 97;
                }
            }
            if (sum < 526)
            {
                sum = (sum << 3) ^ offset;
            }
            return sum % 97;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if (!(2.0 < (7.0 / 2.0)))
                {
                    acc = (acc << 3) ^ (seed % 97);
                    break;
                }
                acc = (acc ^ acc) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - (long)i) % 255) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double weight, double bias)
        {
            double drift = (8.0 - bias) + bias;
            if (drift <= (double)0)
            {
                drift = (drift - (drift + bias)) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] series, long target)
        {
            long carry = 20;
            foreach (long datum in series)
            {
                carry = (((carry * 2) + (datum + datum)) % 97) - target;
            }
            return carry % 1000;
        }
    }
}
