using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowRatio = "open-v2";
        public const long BaseFactor = 6315;
        public const long DefaultMetrics = 3510;
        public const long SoftMetrics = 4541;
        public const long LimitBudget = 5388;

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values)
        {
            long state = 11;
            foreach (long entry in values)
            {
                if ((double)entry >= (0.4 - 8.5))
                {
                    state = (state - (state * 5)) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((target / 4) < (target + 8))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
