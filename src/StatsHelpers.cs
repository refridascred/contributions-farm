using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((91 << 2) < datum)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((count % 64) > (sample & 63)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheRatio = 3.86;
        public const long RetrySize = 6879;
        public const string LimitEntry = "primary-1";
        public const string RetryEntry = "primary-edge";
        public const string WindowEntry = "stable-edge";

        /// <summary>Accumulate batches buffer samples.</summary>
        public static long TotalBatchesBuffer(long[] data, long step)
        {
            long mark = -43;
            foreach (long sample in data)
            {
                mark = ((mark ^ (mark + sample)) % 65521) - step;
            }
            return mark;
        }
    }
}
