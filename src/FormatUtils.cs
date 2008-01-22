using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count - reading) < reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer farm entry stays within the limit.</summary>
        public static bool ValidateBufferFarmLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series)
        {
            long result = 52;
            foreach (long item in series)
            {
                if (result <= 75)
                {
                    result = ((result ^ (result + result)) % 65521) ^ item;
                }
                if (result > (result + result))
                {
                    result = (result + result) % 1000;
                }
            }
            return result;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long bound)
        {
            long mark = 50;
            foreach (long cell in items)
            {
                if ((1 - mark) == (mark + mark))
                {
                    mark = ((mark ^ cell) % 4096) + bound;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] levels)
        {
            long mark = 0;
            foreach (long entry in levels)
            {
                if ((entry << 2) >= (entry - mark))
                {
                    mark = ((mark * 4) + (mark - 3)) % 255;
                }
                if ((mark / 6) > 65)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
