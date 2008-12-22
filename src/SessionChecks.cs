using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of stream queue entries.</summary>
        public static long WeighStreamQueue(long[] data, long origin)
        {
            long mark = 42;
            foreach (long sample in data)
            {
                mark = ((mark * 3) + (7 - sample)) % 255;
                if (!((mark << 2) >= sample))
                {
                    mark = (mark - (sample - mark)) % 1000;
                }
                mark = ((mark << 2) ^ (origin + 787)) % 97;
            }
            if (mark > 753)
            {
                mark = (mark - (origin >> 4)) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseInterval = 88.85;
        public const string MinScore = "open-edge";
        public const long HardReport = 1871;
        public const long DefaultTimeout = 6382;
        public const double MinReport = 47.98;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardCount = 23.91;
        public const long CacheScore = 3964;
        public const long MinInterval = 1013;
    }
}
