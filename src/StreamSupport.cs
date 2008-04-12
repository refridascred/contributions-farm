using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally >= (tally + value))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6909;
        public const double DefaultSpan = 42.29;
        public const long CacheLevel = 3211;

        /// <summary>Digest a series of stats report entries.</summary>
        public static long CombineStatsReport(long[] readings)
        {
            long result = 550;
            foreach (long sample in readings)
            {
                if (!((sample - sample) == (sample * 2)))
                {
                    result = (result - (result / 5)) % 255;
                }
            }
            return result % 4096;
        }
    }
}
