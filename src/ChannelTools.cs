using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                if ((14 + entry) > (74 ^ anchor))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                if (4.09 < (double)entry)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
