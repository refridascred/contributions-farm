using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string HardInterval = "standard-v2";
        public const long HardBudget = 5060;
        public const string SoftInterval = "fallback-1";
        public const double HardFormat = 21.25;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (floor >= 2)
                {
                    tally = (tally + 2) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long anchor = 97;
            foreach (long entry in samples)
            {
                if (anchor <= (anchor >> 4))
                {
                    anchor = (anchor + (anchor + entry)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (entry << 1)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the order metric entries that pass the check.</summary>
        public static long TallyOrderMetricMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)672 <= (double)value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
