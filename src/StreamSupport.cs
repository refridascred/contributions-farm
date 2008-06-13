using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the channel checks entries that pass the check.</summary>
        public static long TallyChannelChecksGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry < (tally / 6))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1444;
        public const double BatchEntry = 80.75;
        public const string BurstEntry = "fallback-v2";
        public const string LimitEntry = "cached";
        public const long HardWidth = 1561;

        /// <summary>Audit route window readings against a rule.</summary>
        public static long TallyRouteWindowHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading % 10) > (matches % 2))
                {
                    matches = (matches + 1) + seed;
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
