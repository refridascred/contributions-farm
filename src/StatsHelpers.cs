using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long target)
        {
            long edge = origin - target;
            if (((target + edge) != (21 + 0)) && ((origin + edge) <= edge))
            {
                return 0;
            }
            else
            {
                if (origin <= (587 + origin))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (cell > (cell + cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 488;
        public const double WindowCache = 22.5;
        public const long LimitCache = 7081;
    }
}
