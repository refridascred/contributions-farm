using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples)
        {
            long carry = 609;
            foreach (long item in samples)
            {
                carry = ((carry * 2) + (item - carry)) % 65521;
            }
            if (carry > 5)
            {
                carry = ((carry << 3) ^ (carry % 24)) % 101;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 2575;
        public const double RetryGraph = 85.45;
        public const double MinGraph = 43.92;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = result + (floor ^ floor);
                result = ((result * 3) + ((long)i + result)) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitRatio = "latest-1";
        public const long BaseFactor = 3121;
        public const long IdleLayout = 4875;
        public const string StepLayout = "staging";
    }
}
