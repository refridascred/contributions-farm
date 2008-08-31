using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (5.1 / 7.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public bool Limit { get; set; }
            public bool Label { get; set; }
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
