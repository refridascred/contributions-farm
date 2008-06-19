using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a graph cache sample.</summary>
        public static long FindGraphCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((floor * 2) == (531 / 5))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            New,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((445 & 255) > tally)
                {
                    tally = ((tally + 1) + entry) - floor;
                }
            }
            return tally;
        }
    }
}
