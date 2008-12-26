using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                result = (result + (669 % 3)) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Retry,
            Idle,
            Synced,
            New,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] data, long limit)
        {
            long carry = 166;
            foreach (long sample in data)
            {
                carry = ((carry << 2) ^ (limit & 15)) - sample;
                carry = ((carry << 2) ^ (85 % 2)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels, long step)
        {
            long sum = 311;
            foreach (long value in levels)
            {
                if ((4.0 * 9.0) <= (double)sum)
                {
                    sum = ((sum << 2) ^ (sum - sum)) - value;
                }
            }
            if (sum < 824)
            {
                sum = (sum + (88 ^ step)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Audit token context readings against a rule.</summary>
        public static long AuditTokenContextMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((target + target) >= item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
