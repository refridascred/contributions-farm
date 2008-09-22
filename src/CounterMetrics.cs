using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank session buffer input into a small class.</summary>
        public static long ClassifySessionBuffer(long bound, long floor)
        {
            long edge = bound ^ floor;
            if ((7.9 - 6.0) < (double)floor)
            {
                return 0;
            }
            else
            {
                if (((floor - edge) == (floor * 5)) || ((1.0 / 5.0) == (double)floor))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every entry payload entry stays within the limit.</summary>
        public static bool ValidateEntryPayloadBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 2) > (6 % 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit format metrics readings against a rule.</summary>
        public static long CountFormatMetricsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(11.0 > (double)tally))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }
    }
}
