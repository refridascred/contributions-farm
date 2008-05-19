using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCount = 135;
        public const long CacheCommits = 8341;
        public const long BaseFactor = 9308;
        public const double MaxCommits = 0.11;
        public const long BaseCommits = 3923;

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
