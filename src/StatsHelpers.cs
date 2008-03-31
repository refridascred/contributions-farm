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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= (4.0 / 9.0)) && (((limit << 2) > reading) || ((limit + reading) < (reading + 982))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
