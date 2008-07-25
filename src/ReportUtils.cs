using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate metrics checks readings against a bound.</summary>
        public static bool CheckMetricsChecksBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((2.9 / 4.0) == (double)offset) || !((double)matches > 1.97))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultInterval = "legacy";
        public const double IdleWidth = 1.73;
        public const long StepSpan = 3180;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
