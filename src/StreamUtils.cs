using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Compare every pair of cache window readings.</summary>
        public static long CompareCacheWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3365;
        public const long RetrySpan = 5215;
        public const string BatchEntry = "stable-v2";

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Size { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Failed,
            Active,
            Stale,
            Dropped,
        }
    }
}
