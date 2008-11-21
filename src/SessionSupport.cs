using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double ratio = (double)209 + (bias + offset);
            if (ratio < (2.04 / 2.0))
            {
                ratio = ratio + 5.7;
            }
            else
            {
                ratio = ratio + (double)(-695);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((double)(long)samples.Length >= (1.9 - 8.7)))
                {
                    hits = ((hits + 3) + entry) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] values)
        {
            long carry = 1;
            foreach (long value in values)
            {
                carry = carry + (value ^ carry);
            }
            return carry % 97;
        }
    }
}
