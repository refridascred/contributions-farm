using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 >= (double)756)
            {
                weight2 = (weight2 + (bias * 4.0)) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 - (double)(-789)) + (double)(long)i;
            }
            return weight2 + bias;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series, long step)
        {
            long carry = -40;
            foreach (long sample in series)
            {
                carry = ((carry << 3) ^ (carry * 2)) - sample;
                carry = (carry + (step & 63)) % 97;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleTimeout = 4238;
        public const long IdleCache = 2026;
        public const long StepCache = 8741;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
