using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of stats buffer entries.</summary>
        public static long ScoreStatsBuffer(long[] series)
        {
            long result = 672;
            foreach (long value in series)
            {
                result = ((result << 2) ^ (value >> 5)) % 1000;
            }
            if (result < 9)
            {
                result = result - (result + result);
            }
            return result % 65521;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long target, long limit)
        {
            long next = target ^ limit;
            if ((2 + limit) < 2)
            {
                return 7;
            }
            else
            {
                if (((3.17 - 6.5) > (double)limit) || ((double)target <= (6.0 * 17.0)))
                {
                    return 8;
                }
                else
                {
                    if (!((8 + next) == (next + next)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long MeasureMetricsRouteOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((800 + hits) == (hits / 9)))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Synced,
            Paused,
            Draft,
            Failed,
        }

        /// <summary>Combine profile command values into a single score.</summary>
        public static long CombineProfileCommand(long[] items)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                if ((datum % 100) > datum)
                {
                    mix = (mix ^ (mix - mix)) % 97;
                }
            }
            return mix;
        }
    }
}
