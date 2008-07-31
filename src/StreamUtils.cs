using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entry entries that pass the check.</summary>
        public static long MeasureCommitsEntryMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally != (double)step)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 6077;
        public const long MinBatches = 4502;
        public const long WindowSpan = 1922;
        public const long RetryBatches = 8767;
        public const long BatchTimeout = 7101;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 568;
        public const long MinBudget = 3448;
        public const long HardBatch = 5523;
    }
}
