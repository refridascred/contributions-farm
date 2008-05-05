using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample + offset) >= (offset / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank record contributi input into a small class.</summary>
        public static long GradeRecordContributi(long seed, long floor)
        {
            if ((double)seed < (7.73 - 4.68))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= (8.8 * 1.64))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 1863;
        public const long DefaultContributi = 4411;
        public const long MinContributi = 1535;
        public const string MinSpan = "latest-v2";
        public const string HardContributi = "alpha-edge";

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((0 + count) < count) && (((long)items.Length & 15) < (seed * 2))) && ((4 >> 5) <= (value - 8)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
