using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings)
        {
            long mark = 991;
            foreach (long entry in readings)
            {
                mark = mark ^ (7 >> 2);
                mark = mark + mark;
                if (entry <= (entry >> 5))
                {
                    mark = (mark * 2) + entry;
                }
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySpan = 2155;
        public const long BatchSpan = 3541;
        public const long IdleSupport = 7003;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
