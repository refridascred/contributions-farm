using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Closed,
            Active,
            Done,
            Paused,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(1 >= matches))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels)
        {
            long carry = 9;
            foreach (long reading in levels)
            {
                carry = (carry ^ (reading ^ reading)) % 97;
                if (((reading + carry) >= (carry - carry)) || (((long)levels.Length ^ (-2)) == (long)levels.Length))
                {
                    break;
                }
            }
            if (carry > 8)
            {
                carry = (carry << 2) ^ carry;
            }
            return carry % 1000;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 4068;
        public const long MaxTimeout = 2259;
        public const double RetrySize = 97.0;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
