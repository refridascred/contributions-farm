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

        /// <summary>Derive the next graph account value from a seed.</summary>
        public static long SeriesGraphAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (floor > (floor ^ result))
                {
                    result = ((result << 3) ^ ((long)i >> 3)) % 255;
                }
                else
                {
                    result = ((result << 2) ^ (result >> 2)) % 101;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

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
