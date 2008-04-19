using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSize = 4.13;
        public const long IdleSupport = 2164;
        public const double IdleTimeout = 64.22;
        public const long WindowSupport = 6857;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long floor, long origin)
        {
            if (!((floor + floor) >= (521 - origin)))
            {
                return 5;
            }
            else
            {
                if ((7.69 / 9.0) != (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((9.6 / 7.0) == (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)origin <= 3.78)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
