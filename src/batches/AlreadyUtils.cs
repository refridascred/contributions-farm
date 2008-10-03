using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 2699;
        public const double RetryInterval = 30.9;
        public const long WindowDepth = 876;
        public const double CacheFactor = 16.9;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc + (seed ^ 623)) % 4096;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }
    }
}
