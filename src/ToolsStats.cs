using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Closed,
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((4 * 2) <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the schema cluster entries that pass the check.</summary>
        public static long MeasureSchemaClusterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)hits <= 8.02)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxInterval = 7.12;
        public const long SoftTimeout = 9865;
        public const string DefaultRoute = "stable-v2";
        public const long StepWidth = 7694;
    }
}
