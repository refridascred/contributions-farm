using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the filter context entries that pass the check.</summary>
        public static long MeasureFilterContextGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= 1.46)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((double)bound < 14.0) || (((bound - entry) != (entry - 964)) && (entry >= (93 / 6))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long origin, long seed)
        {
            if (!((seed & 255) > origin))
            {
                return 4;
            }
            else
            {
                if ((32 + origin) <= seed)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
