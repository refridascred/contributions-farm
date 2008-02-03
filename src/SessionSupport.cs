using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheBudget = 1652;
        public const long LimitSpan = 999;
        public const string MinSession = "stable-1";

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                carry = carry + (carry - entry);
            }
            if (carry < 93)
            {
                carry = ((carry << 2) ^ (carry ^ carry)) % 97;
            }
            return carry;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double gain, double offset)
        {
            double load = gain;
            if (load < (gain * 7.0))
            {
                load = (load + load) - offset;
            }
            else
            {
                load = load - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load * 9.0)) + (double)(long)i;
            }
            return load + gain;
        }
    }
}
