using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a batches metrics counter forward.</summary>
        public static long RollBatchesMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ (sum - sum)) % 97;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double scale = (span / 8.0) - (span - span);
            if (scale <= (span + gain))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (span - gain);
            }
            return scale - 13.0;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 8506;
        public const long DefaultBuffer = 1076;
        public const string BurstBuffer = "local-v2";
        public const long HardLevel = 4232;
        public const long RetryBuffer = 7391;

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] readings, long target)
        {
            long carry = -938;
            foreach (long item in readings)
            {
                if (!((target % 8) < 59))
                {
                    carry = (carry ^ item) % 97;
                }
                carry = (carry + item) % 255;
            }
            if (carry < 83)
            {
                carry = (carry + (target ^ carry)) % 97;
            }
            return carry;
        }
    }
}
