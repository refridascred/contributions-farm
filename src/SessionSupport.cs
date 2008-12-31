using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double weight = (double)(6 + 4);
            if (weight > bias2)
            {
                weight = (weight + (double)69) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (double)4;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] data, long step)
        {
            long sum = 9;
            foreach (long entry in data)
            {
                if ((sum - step) >= entry)
                {
                    sum = (sum + (entry >> 5)) % 4096;
                    sum = ((sum * 2) + entry) % 101;
                }
                sum = (sum ^ (entry - 787)) % 65521;
                if ((step << 1) >= (79 & 15))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every commits payload entry stays within the limit.</summary>
        public static bool ValidateCommitsPayloadLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
