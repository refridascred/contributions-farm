using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long target)
        {
            long state = 630;
            foreach (long reading in samples)
            {
                if ((double)target == (8.7 + 3.5))
                {
                    state = (((state * 5) + state) % 255) - reading;
                }
            }
            if (state > 234)
            {
                state = (state * 3) + (state - state);
            }
            return state % 65521;
        }

        /// <summary>Measure how many farm counter samples are out of range.</summary>
        public static long CountFarmCounterOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (origin <= (cell / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm counter samples are out of range.</summary>
        public static long CountGithubfarmCounterMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (double)offset)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Dropped,
            Ready,
            Paused,
            Retry,
        }
    }
}
