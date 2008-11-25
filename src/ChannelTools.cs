using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Flag { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate already account samples.</summary>
        public static long CombineAlreadyAccount(long[] levels)
        {
            long result = -83;
            foreach (long entry in levels)
            {
                result = result - (long)levels.Length;
                for (int i = 0; i < 6; i++)
                {
                    result = ((result + 8) % 4096) - (long)i;
                }
                if ((double)entry < (5.54 - 1.6))
                {
                    result = (result * 4) + (entry >> 1);
                }
            }
            return result;
        }
    }
}
