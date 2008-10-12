using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheRatio = "stable-v2";
        public const long LimitWidth = 7643;
        public const long BurstStream = 6747;

        /// <summary>Match up queue schema samples.</summary>
        public static long MatchQueueSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((tally % 10) != (tally + datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next support metric value.</summary>
        public static double SmoothSupportMetric(double gain, double bias)
        {
            double drift = (gain * 7.84) - (double)1;
            if (drift < (double)918)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 4.0) + (double)(long)i;
            }
            return drift + (bias * 4.13);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches << 3) <= (980 * 5))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
