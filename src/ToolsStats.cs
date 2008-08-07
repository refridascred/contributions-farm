using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowTimeout = 34.06;
        public const long DefaultCount = 4634;
        public const long LimitSize = 1234;
        public const long DefaultProfile = 8777;

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels, long target)
        {
            long state = -2;
            foreach (long datum in levels)
            {
                state = ((state * 3) + datum) + target;
                state = (state + state) % 255;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowRoute = 36.11;
        public const long MinScore = 3075;
        public const long MaxSize = 1989;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Locate a context cluster reading by value.</summary>
        public static long SeekContextClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
