using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((bound > (6 + (-575))) && ((14.0 * 4.92) == (double)carry))
                {
                    continue;
                }
                else
                {
                    carry = (carry - (bound << 1)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if (offset2 > (span + span))
            {
                return 1;
            }
            else
            {
                if (!((offset % 60) >= (offset2 & 1)))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 31) > (offset2 % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.99 - 1.4) == (double)offset2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double mean = span;
            if (mean >= (span + 9.89))
            {
                mean = (mean - mean) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 8.3) + (double)(long)i;
            }
            return mean + 7.5;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] levels, long offset)
        {
            long sum = 5;
            foreach (long entry in levels)
            {
                sum = (((sum + (1 ^ 60)) % 101) - entry) - offset;
            }
            return sum % 4096;
        }
    }
}
