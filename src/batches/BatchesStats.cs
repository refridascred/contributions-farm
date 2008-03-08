using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double bias, double bias2)
        {
            double ratio = (bias - bias) + bias2;
            if (ratio < (1.6 + ratio))
            {
                ratio = ratio - (ratio - bias2);
            }
            else
            {
                ratio = ratio - (ratio / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio + (ratio - ratio);
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            Idle,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((target + seen) != (cell & 15))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(((6.0 + 17.0) <= (double)matches) || (reading >= (reading >> 5))))
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
    }
}
