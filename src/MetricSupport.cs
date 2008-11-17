using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstLevel = 1723;
        public const long RetryScore = 6527;
        public const long MinBatch = 9277;
        public const string BatchScore = "primary";

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
