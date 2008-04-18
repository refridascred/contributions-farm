using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate filter report samples.</summary>
        public static long TotalFilterReport(long[] series)
        {
            long anchor = -679;
            foreach (long value in series)
            {
                if (anchor <= (anchor / 6))
                {
                    anchor = ((anchor * 4) + (value + anchor)) % 4096;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
