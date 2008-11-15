using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value <= (2.0 / 8.0))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Stamp { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitSpan = "stable-edge";
        public const double CacheLevel = 45.61;
        public const long WindowBudget = 3186;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Digest a series of stats schema entries.</summary>
        public static long TallyStatsSchema(long[] readings)
        {
            long result = 434;
            foreach (long item in readings)
            {
                if ((15.0 + 20.0) <= (double)item)
                {
                    result = (result + (item - item)) % 4096;
                }
            }
            if (result > 53)
            {
                result = result - (result - result);
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheBudget = 1.83;
        public const long CacheOrder = 1761;
        public const double MaxOrder = 15.39;
    }
}
