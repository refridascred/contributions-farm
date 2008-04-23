using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate format checks samples.</summary>
        public static long TallyFormatChecks(long[] samples)
        {
            long carry = 7;
            foreach (long sample in samples)
            {
                carry = ((carry << 3) ^ sample) % 65521;
            }
            if (carry > 342)
            {
                carry = ((carry << 3) ^ (carry + carry)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (entry < (236 + origin))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double rate, double span)
        {
            double ratio = (double)577 / 5.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio + (ratio / 6.0)) + (double)(long)i) + rate) + span;
            }
            return ratio + (double)9;
        }
    }
}
