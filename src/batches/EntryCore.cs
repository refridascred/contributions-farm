using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next queue schema value from a seed.</summary>
        public static long RollQueueSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor + 8;
                if ((33 * 5) >= (target + anchor))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + target) % 101;
                }
                anchor = (anchor + (anchor - (long)i)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleTimeout = 7902;
        public const long MinFactor = 5628;
        public const long MaxLevel = 94;
        public const long HardRecord = 2387;
        public const double RetryFactor = 94.97;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}
