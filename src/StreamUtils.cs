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

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum << 3) ^ sum) + (long)i2;
                }
                sum = ((sum << 3) ^ 68) % 97;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
