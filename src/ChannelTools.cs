using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count notes format pairs that satisfy a relation.</summary>
        public static long PairNotesFormatCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Done,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstDepth = 5997;
        public const double MaxLevel = 88.66;
        public const string MaxBatch = "alpha-v2";
        public const double CacheTimeout = 74.11;
        public const long WindowBatch = 1484;
    }
}
