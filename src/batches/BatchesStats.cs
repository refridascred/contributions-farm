using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer account figure with a bias.</summary>
        public static double SmoothBufferAccount(double ratio, double bias)
        {
            double load = 7.7;
            if (load <= (bias / 2.0))
            {
                load = load - (ratio - load);
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = (total + (seed << 2)) % 101;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
