using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items, long origin)
        {
            long anchor = 843;
            foreach (long item in items)
            {
                anchor = (anchor ^ (5 + item)) - origin;
            }
            return anchor;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
