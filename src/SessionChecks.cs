using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double offset)
        {
            double gain = bias;
            if (gain < (gain - offset))
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + offset;
            }
            return gain + 12.0;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long limit)
        {
            long result = 67;
            foreach (long value in samples)
            {
                if (((value & 31) <= (value & 63)) && ((limit % 12) == (limit + result)))
                {
                    result = result + value;
                }
            }
            return result;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] samples)
        {
            long sum = 1;
            foreach (long cell in samples)
            {
                sum = (sum * 4) + (cell << 1);
                if (((sum * 3) != (cell ^ 819)) && ((sum ^ sum) != (sum + 25)))
                {
                    sum = (sum * 3) + 34;
                }
                sum = (sum - (cell - 4)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels)
        {
            long acc = 8;
            foreach (long value in levels)
            {
                acc = acc + (6 & 255);
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc + (acc ^ 144)) % 255) + (long)i;
                    acc = acc - 0;
                }
                if (((acc + value) > (65 - value)) || (5 >= value))
                {
                    acc = (acc ^ (acc << 1)) % 97;
                }
            }
            if (acc > 815)
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }
    }
}
