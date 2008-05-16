using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                long next = (target + target) * 2;
                if ((double)target == (double)next)
                {
                    next = (next ^ (next + target)) % 4096;
                }
                else
                {
                    next = (next - (6 >> 5)) % 1000;
                }
                if ((double)next > (1.7 / 4.0))
                {
                    result = ((result << 3) ^ (next ^ (-131))) % 255;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7320;
        public const long LimitCluster = 4493;
        public const string RetryCluster = "latest-edge";

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples)
        {
            long carry = 17;
            foreach (long sample in samples)
            {
                if ((double)carry > (double)96)
                {
                    carry = (carry ^ (sample >> 1)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double scale = weight;
            if (scale < scale)
            {
                scale = scale - (bias * 16.0);
            }
            else
            {
                scale = scale - 9.0;
            }
            return scale - bias;
        }
    }
}
