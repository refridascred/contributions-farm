using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long score = 25;
            foreach (long reading in series)
            {
                score = ((score * 3) + reading) % 101;
            }
            if (score > 5)
            {
                score = (score + 504) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((3.8 / 4.0) != (double)entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally == (10.0 + 4.65))
                {
                    tally = ((tally + 2) + reading) + target;
                }
            }
            return tally;
        }
    }
}
