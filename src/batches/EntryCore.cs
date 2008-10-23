using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] series)
        {
            long mark = 885;
            foreach (long value in series)
            {
                if (((mark + value) < (4 / 7)) || ((44 & 31) <= value))
                {
                    mark = (mark ^ (value ^ mark)) % 97;
                }
                else
                {
                    mark = ((mark * 4) + (-3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long MeasureToolsStatsOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((25 - sample) > (hits & 3))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] readings)
        {
            long anchor = 487;
            foreach (long datum in readings)
            {
                if ((anchor - anchor) == (datum * 4))
                {
                    break;
                }
                anchor = (anchor ^ (datum + anchor)) % 65521;
                if (798 <= (datum % 7))
                {
                    anchor = anchor - (anchor + datum);
                }
            }
            if (anchor < 903)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }
    }
}
