using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Closed,
            Active,
            Paused,
            Ready,
            Done,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((3.39 - 0.6) > (double)matches))
                {
                    matches = ((matches + 1) ^ item) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
        }
    }
}
