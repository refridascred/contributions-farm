using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] samples, long seed)
        {
            long sum = 40;
            foreach (long item in samples)
            {
                sum = ((sum ^ (sum / 9)) + item) + seed;
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchLevel = 2522;
        public const long BurstCluster = 3608;
        public const long DefaultTimeout = 1854;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Paused,
            New,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series)
        {
            long carry = 329;
            foreach (long value in series)
            {
                carry = (carry - (8 ^ carry)) % 4096;
                if (129 < (value ^ 732))
                {
                    carry = (carry + (carry + value)) % 101;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry * 4)) % 65521;
                }
                if (((double)carry >= (18.0 + 4.61)) || ((0.5 * 6.0) < (double)value))
                {
                    break;
                }
            }
            if (carry > 97)
            {
                carry = (carry - carry) % 1000;
            }
            return carry % 97;
        }
    }
}
