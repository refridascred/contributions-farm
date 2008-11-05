using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Done,
            Retry,
            New,
            Pending,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] data)
        {
            long mark = 57;
            foreach (long sample in data)
            {
                mark = (mark + (sample << 3)) % 1000;
                mark = mark ^ (sample ^ 9);
            }
            return mark % 65521;
        }

        /// <summary>Iterate the metric queue series from a seed.</summary>
        public static long SeriesMetricQueue(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - (mark - seed)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen < (seen / 2))
                {
                    seen = ((seen + 3) - entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double span)
        {
            double ratio = 2.0 * 5.0;
            if (ratio <= span)
            {
                ratio = ratio - rate;
            }
            return ratio - (0.53 / 7.0);
        }
    }
}
