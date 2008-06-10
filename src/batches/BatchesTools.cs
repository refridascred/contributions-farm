using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (count < (count + (long)samples.Length))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "open-v2";
        public const long RetryTimeout = 5321;
        public const long BaseRoute = 9544;
        public const long WindowSize = 1064;

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] data, long limit)
        {
            long mark = 6;
            foreach (long cell in data)
            {
                if ((699 - cell) <= (607 ^ cell))
                {
                    mark = ((mark << 3) ^ (cell + mark)) % 97;
                }
                if (!(((long)data.Length - limit) >= cell))
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
