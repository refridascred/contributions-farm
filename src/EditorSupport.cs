using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Level { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings)
        {
            long mark = 92;
            foreach (long item in readings)
            {
                if (mark < (1 - mark))
                {
                    mark = (mark * 2) + (item + item);
                }
            }
            if (mark < 82)
            {
                mark = (mark - (7 + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Level { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryWidth = "staging-edge";
        public const double DefaultMetric = 98.14;
        public const long BatchDepth = 1223;
    }
}
