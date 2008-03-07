using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCount = "latest-edge";
        public const long MinSize = 1142;
        public const long LimitRatio = 3190;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)floor >= (double)2)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Classify a already notes pair into a bucket.</summary>
        public static long RankAlreadyNotes(long target, long seed)
        {
            if (((double)seed != (15.0 + 6.1)) || ((seed << 1) < (target / 6)))
            {
                return 3;
            }
            else
            {
                if ((seed + seed) >= target)
                {
                    return 5;
                }
                else
                {
                    if (seed < (target % 60))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
