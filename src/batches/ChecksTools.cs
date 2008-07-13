using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long step)
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

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 5107;
        public const double IdleSupport = 76.73;
        public const long HardDepth = 7085;
        public const long CacheSupport = 2851;
        public const long BaseSupport = 8582;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
