using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches + matches) <= matches) && ((matches * 4) <= (50 - matches)))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long bound)
        {
            if (((1.4 - 2.0) != (double)target) && ((bound + bound) <= 9))
            {
                return 1;
            }
            else
            {
                if ((double)bound <= (1.5 / 8.0))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
