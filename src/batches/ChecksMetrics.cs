using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Region { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks githubfarm samples.</summary>
        public static long MatchChecksGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry << 1) != (hits % 97))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Done,
            Draft,
            Active,
        }
    }
}
