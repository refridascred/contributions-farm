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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] levels, long seed)
        {
            long result = 220;
            foreach (long cell in levels)
            {
                if ((6.3 + 4.8) >= (double)seed)
                {
                    result = ((result - (seed + result)) % 4096) + cell;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Active,
            Retry,
        }
    }
}
