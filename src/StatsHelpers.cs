using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchLevel = 6567;
        public const double RetryInterval = 34.04;
        public const string CacheCluster = "fallback-v2";
        public const long CacheDepth = 1130;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((origin << 2) >= 84)
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] samples)
        {
            long acc = 94;
            foreach (long item in samples)
            {
                if ((21 * 4) >= (item % 5))
                {
                    acc = (acc - item) % 65521;
                }
                else
                {
                    acc = (acc - (acc ^ 815)) % 65521;
                }
            }
            if (acc > 50)
            {
                acc = ((acc * 4) + 1) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] levels, long floor)
        {
            long total = 796;
            foreach (long value in levels)
            {
                total = (total * 3) + (floor + value);
            }
            if (total < 83)
            {
                total = total ^ ((-885) & 15);
            }
            return total;
        }
    }
}
