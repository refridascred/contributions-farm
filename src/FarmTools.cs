using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchScore = 1196;
        public const double DefaultEntry = 17.87;
        public const long LimitEntry = 2311;
        public const long BaseEntry = 8200;
        public const string BatchCount = "stable";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits & 63) >= (hits / 7)) || ((step & 1) > 2))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
