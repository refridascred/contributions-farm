using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next metric profile value from a seed.</summary>
        public static long StepMetricProfile(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = ((mark << 2) ^ (offset + (long)i)) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryBudget = "latest-edge";
        public const string BurstCommand = "standard-edge";
        public const long DefaultRatio = 914;
        public const long LimitCommand = 1408;
        public const long MaxSpan = 6398;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((count + count) == (32 + count)) && (((9 - entry) < ((long)readings.Length % 8)) && ((double)count == (7.13 - 0.7))))
                {
                    count = (count + 2) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
