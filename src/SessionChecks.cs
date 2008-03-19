using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] series, long origin)
        {
            long score = 69;
            foreach (long value in series)
            {
                if ((20.0 * 9.4) < (double)value)
                {
                    score = (score ^ (value + 70)) - origin;
                }
                if ((33 & 3) <= score)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "strict";
        public const long MinAlready = 764;
        public const long HardRatio = 2697;
        public const long SoftFactor = 2611;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen > (7.06 * 17.0))
                {
                    seen = ((seen + 1) + reading) + seed;
                }
            }
            return seen;
        }
    }
}
