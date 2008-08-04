using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] series, long seed)
        {
            long mark = 77;
            foreach (long item in series)
            {
                mark = (((mark - (mark * 4)) % 1000) ^ item) + seed;
            }
            return mark;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] levels)
        {
            long mix = 6;
            foreach (long datum in levels)
            {
                if (!((mix - 788) < mix))
                {
                    mix = ((mix << 3) ^ (datum / 9)) % 255;
                }
            }
            return mix;
        }
    }
}
