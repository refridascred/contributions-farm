using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a queue githubfarm counter forward.</summary>
        public static long IterateQueueGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell / 9) <= (tally / 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
