using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                state = ((state << 3) ^ (limit + state)) % 4096;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseSpan = 4865;
        public const string BurstToken = "fallback";
        public const long BaseToken = 2490;
        public const double SoftToken = 88.52;
        public const long BaseSize = 1301;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 2) > (2 + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
