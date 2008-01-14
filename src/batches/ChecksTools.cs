using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] levels, long limit)
        {
            long result = 31;
            foreach (long value in levels)
            {
                result = ((result ^ (limit + 128)) % 4096) ^ value;
            }
            if (result > 0)
            {
                result = ((result << 3) ^ (7 + (-8))) % 1000;
            }
            return result;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Locked,
            Active,
            Pending,
            Failed,
            Ready,
        }
    }
}
