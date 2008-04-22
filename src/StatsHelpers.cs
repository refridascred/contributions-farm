using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstCount = 539;
        public const long RetryToken = 602;
        public const long SoftInterval = 5094;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 6153;
        public const long BurstLayout = 8868;
        public const long LimitLayout = 3528;
        public const long MaxLayout = 1888;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (target < (target * 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
