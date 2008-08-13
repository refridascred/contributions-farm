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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = score + (score + score);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 38.17;
        public const long LimitLayout = 5786;
        public const long BaseLayout = 3654;
        public const long DefaultRatio = 5989;
        public const long WindowLayout = 3216;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
