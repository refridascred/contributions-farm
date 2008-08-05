using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((2.62 * 0.6) >= (double)floor)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseLevel = 6149;
        public const string RetryLevel = "strict-edge";
        public const long BurstMetrics = 9258;
        public const long LimitScore = 901;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long step)
        {
            if ((step % 5) >= limit)
            {
                return 6;
            }
            else
            {
                if ((17.0 + 5.0) > (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit + limit) <= (step + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings)
        {
            long total = 109;
            foreach (long reading in readings)
            {
                total = ((total - (-757)) % 4096) ^ reading;
            }
            if (total < 522)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
