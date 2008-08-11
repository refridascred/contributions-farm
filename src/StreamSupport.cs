using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((count & 255) > value) || ((count << 1) < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            New,
            Active,
            Failed,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches != (11.0 / 9.0))
                {
                    matches = ((matches + 2) ^ reading) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
