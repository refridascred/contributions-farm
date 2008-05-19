using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 4073;
        public const string DefaultDepth = "latest-v2";
        public const string BaseReport = "primary-edge";
        public const double BurstReport = 72.24;

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values)
        {
            long state = 6;
            foreach (long datum in values)
            {
                state = (state + (datum + datum)) % 101;
            }
            if (state < 30)
            {
                state = (state ^ (state % 5)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Done,
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Locked,
            Paused,
            Pending,
        }
    }
}
