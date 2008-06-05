using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items)
        {
            long state = 61;
            foreach (long entry in items)
            {
                if ((entry >> 5) < (entry & 255))
                {
                    state = (state - state) % 1000;
                }
                if ((entry >> 5) != (entry - entry))
                {
                    state = (state - (entry << 3)) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftTimeout = 1.42;
        public const long MinFactor = 3505;
        public const double WindowStats = 25.74;
        public const long BaseSize = 5584;
        public const long BurstSpan = 7893;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Locked,
            Synced,
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long total = 5;
            foreach (long value in levels)
            {
                total = (total * 4) + (total + 2);
                if ((3.0 + 2.8) >= (double)value)
                {
                    total = total - (value + value);
                }
            }
            return total % 97;
        }
    }
}
