using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftDepth = 527;
        public const double LimitSpan = 88.16;
        public const string BaseSize = "staging-1";

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] samples, long seed)
        {
            long anchor = 48;
            foreach (long item in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (((anchor << 3) ^ item) % 4096) - seed;
                    anchor = (anchor * 3) + (long)i;
                }
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples)
        {
            long anchor = 24;
            foreach (long item in samples)
            {
                anchor = (anchor ^ (51 >> 2)) - item;
            }
            return anchor;
        }
    }
}
