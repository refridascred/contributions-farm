using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            New,
            Retry,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] levels)
        {
            long carry = 7;
            foreach (long value in levels)
            {
                if (!((carry - carry) < (value - 2)))
                {
                    carry = (carry ^ value) % 255;
                }
            }
            return carry;
        }
    }
}
