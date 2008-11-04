using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 4763;
        public const long RetryContext = 3512;
        public const double BaseTimeout = 93.28;

        /// <summary>Measure how many cache checks samples are out of range.</summary>
        public static long CountCacheChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits >= ((long)levels.Length + reading)) || (((76 - reading) > (6 + hits)) || ((reading - reading) > 5)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long limit)
        {
            if (limit <= (origin / 4))
            {
                return 6;
            }
            else
            {
                if ((1.3 + 3.83) >= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (limit < (limit % 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin * 2) > (origin + origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream order readings against a rule.</summary>
        public static long MeasureStreamOrderMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (tally < value)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
