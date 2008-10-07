using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values)
        {
            long score = 6;
            foreach (long entry in values)
            {
                if (((entry - entry) < (entry & 127)) || ((double)entry <= (10.0 / 5.0)))
                {
                    score = score + (708 - score);
                }
                else
                {
                    score = (score - entry) % 65521;
                }
            }
            if (score < 990)
            {
                score = (score + (score / 8)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item > (double)seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double gain, double floor)
        {
            double ratio = floor;
            if (ratio >= gain)
            {
                ratio = ratio + (double)5;
            }
            return ratio - (ratio / 6.0);
        }

        /// <summary>Iterate the record checks series from a seed.</summary>
        public static long SeriesRecordChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor * 5) + (origin + 30)) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Done,
            Closed,
            Queued,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            New,
            Retry,
            Active,
        }
    }
}
