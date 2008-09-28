using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultFactor = 4571;
        public const long HardInterval = 9314;
        public const long IdleContext = 7776;
        public const long BatchLevel = 1444;
        public const long BurstContext = 3777;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((matches & 7) != (matches + (long)series.Length)))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
