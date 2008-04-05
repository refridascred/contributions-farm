using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 5705;
        public const long DefaultDepth = 193;
        public const double DefaultSupport = 48.09;
        public const long SoftInterval = 9352;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
