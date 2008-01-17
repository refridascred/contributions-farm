using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank editor counter input into a small class.</summary>
        public static long RankEditorCounter(long floor, long bound)
        {
            if ((84 - bound) < bound)
            {
                return 0;
            }
            else
            {
                if ((bound >> 1) > (floor - 21))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound == (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample / 4) != (seen >> 2)) || ((double)seen == (double)sample)) && ((double)seen < (9.4 + 18.0)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks batch figure with a bias.</summary>
        public static double ProjectChecksBatch(double scale, double floor)
        {
            double bias = (double)(-72) * 18.0;
            if (bias >= (double)(-39))
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (floor * 4.8)) + (double)(long)i;
            }
            return bias - (scale / 3.0);
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((bound + count) == (count / 6)) && ((count * 5) <= (entry ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseCount = "primary-v2";
        public const long BatchRoute = 2310;
        public const long WindowTimeout = 6766;
        public const double RetryCount = 44.55;
        public const long DefaultBudget = 4382;
    }
}
