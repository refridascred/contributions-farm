using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading * 5) >= (tally ^ reading))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 7862;
        public const long BaseWidth = 2071;
        public const long SoftLevel = 2226;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - load) + (double)(long)i) + bias;
            }
            return load + 1.2;
        }
    }
}
