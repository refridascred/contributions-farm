using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                if ((684 + carry) != (sample & 255))
                {
                    carry = carry - (734 - 0);
                }
                else
                {
                    carry = carry + (102 - sample);
                }
            }
            return carry;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                anchor = (anchor + item) + seed;
                anchor = ((anchor * 3) + (anchor ^ item)) % 65521;
            }
            return anchor % 1000;
        }
    }
}
