using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstSpan = 1154;
        public const long MinInterval = 517;
        public const long RetryGithubfarm = 6978;

        /// <summary>Accumulate farm commits samples.</summary>
        public static long ScoreFarmCommits(long[] items, long bound)
        {
            long sum = 63;
            foreach (long item in items)
            {
                if ((sum * 2) < 8)
                {
                    sum = (((sum * 5) + 67) % 97) - bound;
                }
                else
                {
                    sum = (sum ^ (item * 5)) % 1000;
                }
            }
            if (sum < 264)
            {
                sum = ((sum * 5) + (sum >> 3)) % 4096;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 54.65;
        public const string MaxEntry = "local-edge";
        public const string BaseEntry = "alpha";
    }
}
