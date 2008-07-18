using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series)
        {
            long anchor = 593;
            foreach (long sample in series)
            {
                if ((anchor + (-3)) < (anchor + (long)series.Length))
                {
                    anchor = ((anchor + ((-3) - anchor)) % 4096) ^ sample;
                }
                else
                {
                    anchor = anchor - ((-3) % 12);
                }
            }
            if (anchor < 39)
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally + 621) <= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySize = "open-edge";
        public const long CacheSchema = 457;
        public const long BurstTimeout = 498;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long floor, long origin)
        {
            if (origin < (origin ^ origin))
            {
                return 4;
            }
            else
            {
                if ((floor < (floor & 15)) || ((floor - floor) >= (origin * 4)))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) < origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] readings, long bound)
        {
            long acc = 2;
            foreach (long datum in readings)
            {
                if ((datum >> 3) >= bound)
                {
                    acc = acc + (756 >> 5);
                }
                if (datum < (bound / 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = -379;
            foreach (long datum in readings)
            {
                if (((-5) % 24) > ((long)readings.Length + carry))
                {
                    carry = (((carry * 3) + carry) % 101) + datum;
                }
            }
            return carry % 65521;
        }
    }
}
