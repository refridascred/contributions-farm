using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a cluster filter sample.</summary>
        public static long FindClusterFilterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] readings)
        {
            long carry = 8;
            foreach (long item in readings)
            {
                carry = ((carry ^ (carry % 8)) % 255) ^ item;
            }
            if (carry > 289)
            {
                carry = (carry + (carry >> 2)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Adjust a batch cluster reading.</summary>
        public static double ScaleBatchCluster(double bias, double bias2)
        {
            double drift = bias2;
            return (drift - (8.4 / 7.0)) + bias;
        }
    }
}
