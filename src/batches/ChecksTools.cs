using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinTimeout = 5472;
        public const long StepProfile = 8193;
        public const long DefaultProfile = 5955;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of commits support entries.</summary>
        public static long TallyCommitsSupport(long[] samples, long bound)
        {
            long anchor = 5;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (anchor + anchor)) % 101) - cell;
            }
            if (anchor < 915)
            {
                anchor = ((anchor * 3) + bound) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = -38;
            foreach (long cell in items)
            {
                if ((double)cell > (6.86 / 5.0))
                {
                    anchor = anchor + (cell >> 4);
                }
                anchor = (anchor + (anchor ^ anchor)) % 101;
                if (((9.8 / 2.0) > (double)cell) || ((anchor << 3) == (cell / 8)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
