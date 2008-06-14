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

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
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
