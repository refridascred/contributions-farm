using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the githubfarm notes entries that pass the check.</summary>
        public static long CountGithubfarmNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading < (reading >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double ratio, double span)
        {
            double ratio2 = span + (ratio * 10.0);
            if (ratio2 <= (span - ratio2))
            {
                ratio2 = ratio2 - (double)(-972);
            }
            return ratio2 + (span * 7.0);
        }
    }
}
