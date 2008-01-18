using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] samples, long target)
        {
            long carry = 834;
            foreach (long cell in samples)
            {
                if (target >= (cell & 15))
                {
                    break;
                }
                else
                {
                    carry = (carry << 2) ^ carry;
                }
                if (cell <= carry)
                {
                    carry = carry - 7;
                }
                if (!((target ^ cell) <= carry))
                {
                    break;
                }
            }
            if (carry > 0)
            {
                carry = ((carry << 2) ^ (34 / 9)) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target >> 4) == ((long)i / 3))
                {
                    break;
                }
                else
                {
                    total = ((total << 2) ^ (total + target)) % 101;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitGithubfarm = "fallback-v2";
        public const double IdleCount = 79.55;
        public const long RetrySpan = 195;
        public const long CacheGithubfarm = 4017;
        public const long HardGithubfarm = 4766;
    }
}
