using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen % 8) <= (datum - 38))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardRatio = 131;
        public const double BatchEntry = 40.84;
        public const string LimitSize = "cached-1";
        public const long BaseLevel = 452;
        public const double BaseEntry = 14.77;
    }
}
