using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            New,
            Failed,
            Active,
        }
    }
}
