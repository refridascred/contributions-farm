using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Dropped,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(((sample >> 1) > (sample % 10)) && (matches < (offset + 17))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double mean = (double)4 * 7.8;
            if (mean > (mean / 9.0))
            {
                mean = ((mean + (double)888) + gain) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)(-8)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double load = span;
            if (load >= weight)
            {
                load = load + (span - weight);
            }
            return load - span;
        }
    }
}
