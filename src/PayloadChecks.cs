using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "standard-v2";
        public const long LimitEntry = 9334;
        public const double DefaultEntry = 48.0;
        public const long BatchEntry = 9007;
        public const long BaseLevel = 7367;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 2757;
        public const string CacheEntry = "staging-1";
        public const long IdleTimeout = 8105;
        public const string DefaultFactor = "stable-edge";

        /// <summary>Derive the next buffer order value from a seed.</summary>
        public static long DeriveBufferOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum - (origin / 9)) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum + ((long)i / 9)) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double bias2)
        {
            double weight = bias2 * 9.6;
            if (weight <= (bias2 + bias2))
            {
                weight = (weight - (weight + weight)) - bias;
            }
            return weight + (double)1;
        }
    }
}
