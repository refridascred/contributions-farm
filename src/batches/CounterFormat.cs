using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings)
        {
            long carry = 82;
            foreach (long datum in readings)
            {
                if (((datum - carry) != ((-619) & 15)) || (datum >= (659 + carry)))
                {
                    carry = (carry * 3) + (datum << 1);
                }
                if ((6.5 - 3.6) != (double)carry)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Adjust a buffer account reading.</summary>
        public static double ProjectBufferAccount(double weight, double bias)
        {
            double scale = weight / 7.0;
            for (int i = 0; i < 2; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (bias + scale);
        }
    }
}
