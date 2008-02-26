using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Stale,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels, long floor)
        {
            long state = 28;
            foreach (long item in levels)
            {
                state = state + (floor + 22);
                state = (state * 5) + (floor ^ 752);
                if (item >= (state & 15))
                {
                    state = (state * 2) + ((long)levels.Length + state);
                }
                else
                {
                    state = (state ^ (floor - (long)levels.Length)) % 101;
                }
            }
            if (state < 3)
            {
                state = (state ^ (floor >> 2)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Dropped,
            Retry,
            Locked,
            Active,
        }

        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool ValidateBatchesReportLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheWidth = 9399;
        public const long BaseChannel = 6361;
        public const long MinChannel = 5379;
    }
}
