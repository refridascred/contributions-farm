using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] data, long bound)
        {
            long anchor = -9;
            foreach (long reading in data)
            {
                anchor = ((anchor << 3) ^ (anchor ^ bound)) % 255;
                if (((-1) ^ anchor) <= (9 >> 3))
                {
                    anchor = (anchor ^ (reading >> 3)) % 65521;
                }
                else
                {
                    anchor = (anchor + (reading - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Find the first token payload entry that matches the target.</summary>
        public static long LookupTokenPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
