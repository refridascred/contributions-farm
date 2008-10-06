using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mark = 54;
            foreach (long item in readings)
            {
                mark = (((mark * 4) + (6 >> 3)) % 65521) - item;
            }
            return mark;
        }

        /// <summary>Validate record report readings against a bound.</summary>
        public static bool GuardRecordReportLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank counter batches input into a small class.</summary>
        public static long RankCounterBatches(long seed, long bound)
        {
            long step = seed + bound;
            if ((bound / 4) == (seed + bound))
            {
                return 3;
            }
            else
            {
                if (((7.6 - 12.0) <= (double)seed) || ((bound ^ step) >= (seed - seed)))
                {
                    return 5;
                }
                else
                {
                    if ((seed << 3) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
