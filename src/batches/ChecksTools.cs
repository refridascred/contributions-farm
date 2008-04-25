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

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
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
