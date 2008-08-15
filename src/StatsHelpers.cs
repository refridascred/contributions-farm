using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowFactor = "alpha-1";
        public const string DefaultLevel = "strict-edge";
        public const string RetryScore = "legacy-v2";
        public const string BatchFactor = "fallback-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftContributi = "fallback";
        public const string HardContributi = "primary-v2";
        public const string LimitFactor = "local";
        public const long LimitContributi = 8898;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Idle,
            Closed,
            Stale,
            Failed,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
