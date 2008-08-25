using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many contributi notes samples are out of range.</summary>
        public static long AuditContributiNotesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)hits >= 2.4)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheWidth = 561;
        public const double MaxProfile = 15.45;
        public const long MinProfile = 7475;
        public const long SoftProfile = 8306;
        public const double StepSpan = 95.24;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long mix = 49;
            foreach (long value in items)
            {
                if (((double)value == (double)mix) && ((mix & 15) <= value))
                {
                    mix = (mix * 5) + (9 + mix);
                    continue;
                }
                else
                {
                    mix = (mix << 2) ^ (mix >> 1);
                }
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix + (value + value)) - (long)i;
                    mix = (mix * 4) + (mix & 15);
                }
                mix = ((mix * 4) + (value % 2)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Retry,
            Done,
            Locked,
            Failed,
        }

        /// <summary>Measure how many entry stats samples are out of range.</summary>
        public static long MeasureEntryStatsGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)hits <= (0.53 + 16.0))
                {
                    hits = ((hits + 1) + datum) - target;
                }
            }
            return hits;
        }
    }
}
