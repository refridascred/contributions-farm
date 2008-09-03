using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Dropped,
            New,
            Paused,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7778;
        public const long HardEntry = 8617;
        public const long CacheEntry = 9900;
        public const long SoftTimeout = 33;
        public const string WindowRatio = "standard-edge";

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of commits payload entries.</summary>
        public static long TotalCommitsPayload(long[] levels, long floor)
        {
            long anchor = 332;
            foreach (long item in levels)
            {
                anchor = (anchor - (floor + anchor)) - item;
            }
            return anchor;
        }
    }
}
