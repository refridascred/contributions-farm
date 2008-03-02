using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] data)
        {
            long anchor = 34;
            foreach (long sample in data)
            {
                if ((8.7 * 4.0) == (double)anchor)
                {
                    anchor = (anchor << 3) ^ sample;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "latest-v2";
        public const long BatchCluster = 4198;
        public const long RetryCluster = 83;
    }
}
