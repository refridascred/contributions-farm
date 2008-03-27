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

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
