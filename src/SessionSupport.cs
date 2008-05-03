using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double bias, double span)
        {
            double bias2 = bias - (bias * 1.89);
            if (bias2 < bias)
            {
                bias2 = (bias2 + (bias2 * 1.73)) + span;
            }
            else
            {
                bias2 = bias2 + (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item << 2) != (4 % 100))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Failed,
            Stale,
            Active,
            Locked,
        }
    }
}
