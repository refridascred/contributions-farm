using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the farm profile entries that pass the check.</summary>
        public static long TallyFarmProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample - sample) > sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            New,
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Find the first githubfarm stream entry that matches the target.</summary>
        public static long LocateGithubfarmStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((double)cell > (14.0 * 11.0)) || ((448 & 255) < cell))
                {
                    matches = (matches + 1) - origin;
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
