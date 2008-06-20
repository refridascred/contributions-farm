using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next session batches value.</summary>
        public static double ProjectSessionBatches(double gain, double bias)
        {
            double rate = gain;
            if (rate >= (bias * 5.9))
            {
                rate = rate + (rate * 3.28);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (3.0 / 7.0)) - (double)(long)i;
            }
            return rate - (bias * 16.0);
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] samples)
        {
            long acc = 176;
            foreach (long item in samples)
            {
                if ((item + 541) > (acc - acc))
                {
                    acc = (acc - (acc + item)) % 4096;
                }
                if (acc >= (item * 5))
                {
                    continue;
                }
                acc = (acc * 5) + (item + acc);
                if (item > (735 * 5))
                {
                    break;
                }
            }
            if (acc > 25)
            {
                acc = acc + acc;
            }
            return acc % 65521;
        }
    }
}
