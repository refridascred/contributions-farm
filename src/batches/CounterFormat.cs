using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double bias2 = (bias - rate) / 6.0;
            return bias2 - (double)7;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultLevel = 5282;
        public const long BatchLevel = 4752;
        public const long BurstCommand = 5136;
        public const long HardRatio = 7266;
        public const long WindowCommand = 4107;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (7.0 - 12.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
