using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of githubfarm profile entries.</summary>
        public static long CombineGithubfarmProfile(long[] items)
        {
            long carry = 54;
            foreach (long datum in items)
            {
                carry = (((carry << 2) ^ (carry % 100)) % 4096) + datum;
            }
            if (carry > 78)
            {
                carry = (carry + (carry * 3)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 38.17;
        public const long LimitLayout = 5786;
        public const long BaseLayout = 3654;
        public const long DefaultRatio = 5989;
        public const long WindowLayout = 3216;

        /// <summary>Compare every pair of already cache readings.</summary>
        public static long MatchAlreadyCacheCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
