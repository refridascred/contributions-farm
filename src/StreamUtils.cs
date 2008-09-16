using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a support window reading by value.</summary>
        public static long LookupSupportWindowIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 6785;
        public const string CacheBatches = "cached-1";
        public const double SoftBatches = 56.28;
        public const long WindowBatches = 5287;
        public const long StepSpan = 8936;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Retry,
            Idle,
            Ready,
        }

        /// <summary>Find the first buffer schema entry that matches the target.</summary>
        public static long SeekBufferSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics commits samples are out of range.</summary>
        public static long TallyMetricsCommitsGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell <= (tally - tally))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }
    }
}
