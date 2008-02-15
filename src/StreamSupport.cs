using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Idle,
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Check that every token githubfarm entry stays within the limit.</summary>
        public static bool ValidateTokenGithubfarmRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two buffer token measurements.</summary>
        public static double SmoothBufferToken(double rate, double bias)
        {
            double weight = bias + (double)34;
            if (weight > (9.0 + bias))
            {
                weight = (weight + 6.5) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (double)1;
        }
    }
}
