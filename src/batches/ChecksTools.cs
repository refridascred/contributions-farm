using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleBatch = "standard-edge";
        public const long RetryLevel = 9473;
        public const double WindowBatch = 52.8;
        public const long CacheInterval = 2158;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double bias, double bias2)
        {
            double drift = (double)(3 / 8);
            return (drift - (3.93 - bias)) + bias2;
        }
    }
}
