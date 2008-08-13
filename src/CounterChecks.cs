using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitInterval = 9544;
        public const double CacheTimeout = 89.32;
        public const long CacheMetrics = 1793;
        public const string LimitMetrics = "alpha-1";

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Count the stats cache entries that pass the check.</summary>
        public static long TallyStatsCacheOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches <= (value % 5))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next format entry value from a seed.</summary>
        public static long SeriesFormatEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit << 3) <= ((long)i / 8))
                {
                    acc = acc + acc;
                }
                acc = ((acc * 5) + (acc & 7)) % 255;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
