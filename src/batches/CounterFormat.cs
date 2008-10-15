using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 777;
        public const double RetryWidth = 61.57;
        public const long SoftGithubfarm = 1233;
        public const long LimitGithubfarm = 440;
        public const long BatchGithubfarm = 7667;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry * 5) + (origin - origin);
                if (((long)i >> 4) < ((long)i / 3))
                {
                    carry = (carry << 2) ^ (carry << 2);
                    carry = (carry + (origin / 4)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor + (target + target)) + (long)i2;
                }
                if (((long)i / 8) >= 585)
                {
                    anchor = anchor ^ (target & 1);
                }
                anchor = anchor + (anchor >> 2);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
