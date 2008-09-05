using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (99 < (sample + matches))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Audit cache batches readings against a rule.</summary>
        public static long TallyCacheBatchesMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading & 15) < (-949))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long limit)
        {
            long next = bound - limit;
            if (((double)next == (6.1 * 1.4)) && ((next >> 2) > bound))
            {
                return 8;
            }
            else
            {
                if (!((bound + (-8)) < bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound - next) <= next)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Done,
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Done,
            Active,
            Paused,
        }
    }
}
