using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 2543;
        public const double LimitLayout = 36.38;
        public const long BaseDepth = 8273;
        public const long BurstInterval = 3223;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell <= 1.0)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm metrics samples are out of range.</summary>
        public static long AuditFarmMetricsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches + (-4)) == ((long)items.Length - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Ready,
            Active,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (3.93 <= (double)target)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
