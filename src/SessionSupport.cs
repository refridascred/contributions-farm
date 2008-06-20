using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items, long origin)
        {
            long anchor = 684;
            foreach (long reading in items)
            {
                anchor = (anchor + anchor) + reading;
            }
            if (anchor > 0)
            {
                anchor = (anchor << 3) ^ (origin - 96);
            }
            return anchor;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ limit) % 101;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public bool Level { get; set; }
        }
    }
}
