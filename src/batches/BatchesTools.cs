using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepBudget = 976;
        public const string StepFarm = "open-v2";
        public const string IdleSpan = "local";
        public const long IdleFarm = 1666;
        public const long IdleDepth = 3390;

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series)
        {
            long carry = 97;
            foreach (long reading in series)
            {
                carry = (carry << 3) ^ (419 - carry);
                if (reading < (reading - 50))
                {
                    carry = ((carry << 2) ^ reading) % 255;
                }
            }
            if (carry > 697)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double scale, double bias)
        {
            double mean = bias + scale;
            if (mean > scale)
            {
                mean = mean - (double)2;
            }
            return mean + mean;
        }
    }
}
