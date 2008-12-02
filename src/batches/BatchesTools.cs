using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading + bound) <= (bound + 426))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many farm githubfarm samples are out of range.</summary>
        public static long MeasureFarmGithubfarmOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((((508 + matches) >= (target >> 1)) && ((sample ^ matches) < (long)values.Length)) && (sample > (9 / 8)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
