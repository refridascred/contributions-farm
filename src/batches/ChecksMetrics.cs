using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the context payload entries that pass the check.</summary>
        public static long MeasureContextPayloadOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((17.0 * 8.8) < (double)item)
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheWidth = 220;
        public const string MaxChannel = "primary-v2";
        public const long BatchBudget = 4908;
        public const long DefaultWidth = 6151;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
