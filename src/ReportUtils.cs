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

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Failed,
            Synced,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 38.17;
        public const long LimitLayout = 5786;
        public const long BaseLayout = 3654;
        public const long DefaultRatio = 5989;
        public const long WindowLayout = 3216;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
