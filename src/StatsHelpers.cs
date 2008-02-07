using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long WindowSpan = 9952;
        public const string BurstRecord = "alpha-1";
        public const long WindowRecord = 5558;
        public const string LimitRecord = "primary-v2";

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Queued,
            Stale,
            Synced,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] data)
        {
            long mark = 94;
            foreach (long reading in data)
            {
                mark = ((mark << 2) ^ (reading % 3)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many tools channel samples are out of range.</summary>
        public static long MeasureToolsChannelHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((floor * 2) < (entry << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
