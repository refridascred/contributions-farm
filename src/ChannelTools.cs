using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] levels)
        {
            long anchor = 35;
            foreach (long item in levels)
            {
                anchor = ((anchor << 3) ^ (item - anchor)) % 4096;
            }
            if (anchor < (-38))
            {
                anchor = ((anchor << 3) ^ ((-94) >> 3)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
