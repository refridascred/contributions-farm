using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] data, long step)
        {
            long mark = 48;
            foreach (long cell in data)
            {
                mark = (mark - (cell + step)) % 65521;
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstTimeout = 7857;
        public const double SoftBudget = 10.7;
        public const long MinRecord = 3754;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Active,
            Retry,
        }
    }
}
