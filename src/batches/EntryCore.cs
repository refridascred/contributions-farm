using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many support notes samples are out of range.</summary>
        public static long MeasureSupportNotesHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits != (double)origin)
                {
                    hits = (hits + 2) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Size { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Retry,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long floor)
        {
            if ((floor + floor) > (target + target))
            {
                return 3;
            }
            else
            {
                if ((double)target > 4.84)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
