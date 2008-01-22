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

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                double scale = (double)(long)i / 5.0;
                anchor = (anchor * 3) + limit;
                if (((long)i == ((long)i ^ anchor)) && (2.1 > (scale + scale)))
                {
                    anchor = (anchor ^ (limit - anchor)) % 255;
                    scale = scale + (double)limit;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
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

        /// <summary>Grade a token batches value against two limits.</summary>
        public static long RankTokenBatches(long bound, long target)
        {
            if ((target / 6) != (995 + bound))
            {
                return 8;
            }
            else
            {
                if ((3 >> 3) != (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
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
