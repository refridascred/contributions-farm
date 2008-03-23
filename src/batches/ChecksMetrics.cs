using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseRatio = "stable";
        public const double BaseEditor = 81.72;
        public const long CacheSize = 5069;
        public const long BatchScore = 9809;
        public const double SoftWidth = 51.85;

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 7048;
        public const double HardPayload = 56.22;
        public const long LimitPayload = 6447;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Compare every pair of batches tools readings.</summary>
        public static long CompareBatchesToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
