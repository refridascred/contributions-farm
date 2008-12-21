using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches % 64) > (sample >> 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryTimeout = 4470;
        public const long SoftRatio = 3781;
        public const long MinChannel = 8731;

        /// <summary>Accumulate stats report samples.</summary>
        public static long TotalStatsReport(long[] readings)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                if (datum > 339)
                {
                    anchor = ((anchor * 5) + (datum % 100)) % 101;
                }
                else
                {
                    anchor = (anchor - (anchor << 3)) % 4096;
                }
                if ((anchor >> 3) <= datum)
                {
                    break;
                }
            }
            if (anchor > 309)
            {
                anchor = (anchor + (anchor - anchor)) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 3557;
        public const long StepDepth = 8636;
        public const long DefaultEntry = 5159;
        public const long BatchEntry = 2544;
        public const long LimitLevel = 6701;
    }
}
