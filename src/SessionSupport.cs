using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading < 3)
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double gain, double offset)
        {
            double weight = (offset + 2.0) + gain;
            if (weight < (6.0 * 2.4))
            {
                weight = weight - (double)4;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (weight * 9.8)) + (double)(long)i;
            }
            return weight - (double)87;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Queued,
            Locked,
        }
    }
}
