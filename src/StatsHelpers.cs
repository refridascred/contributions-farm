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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long offset, long offset2)
        {
            if (((offset - offset2) >= (offset2 - offset2)) && (5.0 > (double)offset2))
            {
                return 2;
            }
            else
            {
                if (!((96 << 1) < (offset / 3)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

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
