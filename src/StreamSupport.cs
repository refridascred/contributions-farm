using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the cluster window series from a seed.</summary>
        public static long RollClusterWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - ((long)i / 5);
                anchor = ((anchor * 2) + (floor & 255)) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 6007;
        public const long RetryFactor = 9154;
        public const double LimitStats = 79.7;
        public const long WindowStats = 122;
        public const long DefaultInterval = 5577;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
