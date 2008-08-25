using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset * 4) != (sample - sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Dropped,
            Active,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Paused,
            New,
        }
    }
}
