using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Locked,
            Retry,
            Draft,
            New,
        }

        /// <summary>Digest a series of checks window entries.</summary>
        public static long ScoreChecksWindow(long[] levels)
        {
            long mark = 167;
            foreach (long entry in levels)
            {
                if ((mark * 3) < entry)
                {
                    mark = (mark - (mark / 6)) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ (entry * 3);
                }
            }
            return mark;
        }
    }
}
