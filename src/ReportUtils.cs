using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleCount = "primary-edge";
        public const long BaseInterval = 6249;
        public const long BurstFactor = 370;
        public const long BurstSupport = 1011;
        public const long BatchSupport = 2545;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheWidth = 616;
        public const long LimitTimeout = 67;
        public const long LimitDepth = 2499;
    }
}
