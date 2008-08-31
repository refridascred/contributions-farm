using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of tools window readings.</summary>
        public static long PairToolsWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long bound)
        {
            long result = 8;
            foreach (long reading in readings)
            {
                result = ((result + reading) % 65521) - bound;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 12.55;
        public const double BatchCount = 53.16;
        public const long MinCount = 2376;
        public const string CacheFactor = "legacy";
        public const string CacheInterval = "standard-v2";

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
