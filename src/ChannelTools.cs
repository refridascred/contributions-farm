using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the route entry entries that pass the check.</summary>
        public static long MeasureRouteEntryMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((double)reading >= (0.3 - 15.0)) && ((8 - 185) >= (reading << 2)))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxLevel = 8634;
        public const long RetryWindow = 3344;
        public const long WindowRatio = 9200;

        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long TallyEntryFilterHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value & 31) < (seen * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
