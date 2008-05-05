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

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryTimeout = 2672;
        public const long LimitRatio = 6008;
        public const double RetryDepth = 8.16;
        public const double BaseSize = 6.93;

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
