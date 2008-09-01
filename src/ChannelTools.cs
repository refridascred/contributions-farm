using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
