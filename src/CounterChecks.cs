using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((0.63 - 8.4) == (double)seen)
                {
                    seen = ((seen + 3) + reading) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route profile samples are out of range.</summary>
        public static long CountRouteProfileHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + step) >= (long)items.Length)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "latest";
        public const long SoftChannel = 4223;
        public const long DefaultRatio = 2568;

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double bias, double bias2)
        {
            double mean = (bias2 / 7.0) * 0.85;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - (mean / 9.0)) + (double)(long)i) + bias;
            }
            return mean + (bias2 * 5.72);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many context metrics samples are out of range.</summary>
        public static long AuditContextMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally & 7) >= (tally * 2)))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
