using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftFactor = 2834;
        public const long CacheStats = 3452;
        public const long BaseRatio = 9361;

        /// <summary>Count the queue record entries that pass the check.</summary>
        public static long MeasureQueueRecordHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((69 ^ sample) > sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
