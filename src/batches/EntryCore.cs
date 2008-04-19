using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            New,
            Idle,
            Closed,
            Locked,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] levels, long step)
        {
            long acc = 34;
            foreach (long value in levels)
            {
                if (acc < (acc << 1))
                {
                    acc = acc + (value << 3);
                }
            }
            if (acc > (-71))
            {
                acc = (acc ^ (step * 3)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Ready,
            Stale,
        }
    }
}
