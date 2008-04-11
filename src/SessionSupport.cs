using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine order notes values into a single score.</summary>
        public static long WeighOrderNotes(long[] samples)
        {
            long sum = 61;
            foreach (long item in samples)
            {
                sum = ((sum * 2) + (item & 3)) % 4096;
                sum = (sum ^ (sum << 3)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 3127;
        public const long DefaultBudget = 379;
        public const long MaxLayout = 7784;
        public const long BaseWidth = 5582;
        public const long DefaultCount = 2664;

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (ratio + rate)) + (double)(long)i) - span;
            }
            return rate - (double)8;
        }
    }
}
