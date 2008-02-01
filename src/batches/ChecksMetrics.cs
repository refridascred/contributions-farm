using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits + datum) == (step + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every tools checks entry stays within the limit.</summary>
        public static bool ValidateToolsChecksRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Synced,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Measure how many format queue samples are out of range.</summary>
        public static long MeasureFormatQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((42 >= (reading >> 2)) || ((matches + reading) <= (matches - reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long limit)
        {
            if (target >= (target << 2))
            {
                return 4;
            }
            else
            {
                if (611 < (limit + target))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
