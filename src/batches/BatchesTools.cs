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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((9.0 - 2.35) < (7.64 * 8.0))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
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
