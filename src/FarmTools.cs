using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally - sample) <= (sample - sample)) && ((sample + 921) < (tally ^ sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the order githubfarm entries that pass the check.</summary>
        public static long AuditOrderGithubfarmHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits ^ value) >= (hits * 5))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
