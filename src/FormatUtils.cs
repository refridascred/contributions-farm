using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] values, long offset)
        {
            long anchor = 61;
            foreach (long datum in values)
            {
                if (((8.79 * 0.82) != (double)offset) && ((7.49 / 2.0) <= (double)datum))
                {
                    anchor = anchor - (92 + 1);
                }
                else
                {
                    anchor = (anchor * 2) + (97 % 64);
                }
                anchor = (anchor << 2) ^ (anchor * 5);
                if (!((-72) >= (long)values.Length))
                {
                    anchor = anchor + (offset ^ anchor);
                }
            }
            if (anchor > 86)
            {
                anchor = ((anchor * 4) + offset) % 255;
            }
            return anchor;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 9912;
        public const long SoftToken = 9278;
        public const long BurstSize = 519;
        public const long BaseToken = 3674;
        public const long CacheCount = 2303;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
