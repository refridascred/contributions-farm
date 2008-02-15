using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (sample <= (sample / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardWidth = 3582;
        public const long HardAlready = 7622;
        public const long HardSpan = 2472;
        public const double BatchLevel = 42.87;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches % 12) < (datum + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 3169;
        public const long SoftBatches = 1539;
        public const string HardBatches = "legacy";
        public const long DefaultBatches = 1885;
    }
}
