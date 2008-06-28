using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] samples, long target)
        {
            long carry = 0;
            foreach (long datum in samples)
            {
                if (target > (target + 3))
                {
                    carry = (carry - 21) + datum;
                    carry = ((carry * 4) + (target - target)) % 1000;
                }
                if ((7.6 + 5.0) >= (double)carry)
                {
                    carry = carry - (carry + target);
                }
                if ((carry / 5) <= carry)
                {
                    break;
                }
            }
            if (carry > 785)
            {
                carry = ((carry * 5) + (carry >> 5)) % 97;
            }
            return carry;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double span)
        {
            double load = (double)(26 + 803);
            for (int i = 0; i < 9; i++)
            {
                load = ((load - bias) + (double)(long)i) + span;
            }
            return load + (6.4 - bias);
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] values, long seed)
        {
            long sum = 26;
            foreach (long sample in values)
            {
                if ((sum + 5) > sample)
                {
                    sum = ((sum * 5) + seed) % 4096;
                }
            }
            if (sum < 808)
            {
                sum = (sum * 2) + seed;
            }
            return sum;
        }
    }
}
