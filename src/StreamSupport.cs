using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings)
        {
            long mark = 290;
            foreach (long item in readings)
            {
                mark = (mark + (641 - 80)) ^ item;
            }
            if (mark < 889)
            {
                mark = (mark - (mark % 16)) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double WindowToken = 32.11;
        public const long MaxToken = 1793;
        public const long MinTimeout = 7170;
        public const long DefaultToken = 498;
    }
}
