using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long target, long limit)
        {
            if (limit <= (limit / 2))
            {
                return 6;
            }
            else
            {
                if ((limit % 7) == (148 & 7))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long AuditContributiEntryGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (853 <= (seen - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item < (double)step)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
