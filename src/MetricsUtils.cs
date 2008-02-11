using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (double)0) - (double)(long)i) + ratio;
            }
            return gain + gain;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepScore = "cached-edge";
        public const string DefaultContributi = "staging-v2";
        public const double StepInterval = 89.36;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] readings, long target)
        {
            long carry = 69;
            foreach (long reading in readings)
            {
                carry = (carry + (reading & 127)) % 4096;
                carry = (carry + target) % 4096;
                if ((7 - reading) <= (reading + carry))
                {
                    carry = (carry << 3) ^ (reading + carry);
                }
                if (2.2 < (double)carry)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
