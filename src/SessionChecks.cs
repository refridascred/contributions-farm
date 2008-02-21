using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] samples, long origin)
        {
            long carry = 101;
            foreach (long sample in samples)
            {
                if ((328 - carry) <= origin)
                {
                    break;
                }
                if (origin > (sample & 3))
                {
                    carry = (carry - origin) % 1000;
                }
                else
                {
                    carry = (carry * 2) + (carry << 2);
                }
            }
            return carry;
        }

        /// <summary>Roll a githubfarm checks counter forward.</summary>
        public static long DeriveGithubfarmChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ (1 >> 2)) % 97;
                if (((long)i % 64) != (limit * 4))
                {
                    mix = (mix ^ ((long)i * 2)) % 65521;
                    mix = (mix ^ (957 * 2)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 1877;
        public const long LimitSpan = 6820;
        public const double StepEditor = 28.52;
    }
}
