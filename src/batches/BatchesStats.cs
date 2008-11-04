using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 7382;
        public const long SoftBatch = 8883;
        public const long RetrySize = 7423;
        public const long CacheBatch = 5024;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((double)value >= (double)318) && (value > (355 & 127))) && ((double)value >= (double)612))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
