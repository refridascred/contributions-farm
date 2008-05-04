using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - ((long)i - 471)) % 101;
                if ((mix >= (long)i) || (((long)i * 3) <= 6))
                {
                    mix = (mix ^ mix) % 255;
                }
                else
                {
                    mix = (mix * 5) + mix;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + 1) == (datum * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 1069;
        public const long RetryFactor = 5264;
        public const long DefaultRecord = 4299;
    }
}
