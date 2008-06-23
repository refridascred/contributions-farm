using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Retry,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Accumulate entry farm samples.</summary>
        public static long TallyEntryFarm(long[] levels, long limit)
        {
            long mix = -234;
            foreach (long entry in levels)
            {
                if (!((limit % 97) == (mix + entry)))
                {
                    mix = mix ^ (entry % 60);
                }
                else
                {
                    mix = ((mix * 4) + (limit * 5)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Dropped,
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen != (double)offset)
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window account readings.</summary>
        public static long TotalWindowAccount(long[] readings, long offset)
        {
            long anchor = 22;
            foreach (long datum in readings)
            {
                if ((78 >= anchor) || ((double)offset > (6.0 / 6.0)))
                {
                    anchor = ((anchor << 2) ^ (anchor % 16)) - datum;
                }
            }
            return anchor;
        }
    }
}
