using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryTimeout = 4973;
        public const long DefaultFactor = 9702;
        public const long HardDepth = 2673;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits <= sample) || !(hits < sample))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
