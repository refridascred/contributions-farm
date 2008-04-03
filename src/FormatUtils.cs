using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] values, long offset)
        {
            long anchor = 61;
            foreach (long datum in values)
            {
                if (((8.79 * 0.82) != (double)offset) && ((7.49 / 2.0) <= (double)datum))
                {
                    anchor = anchor - (92 + 1);
                }
                else
                {
                    anchor = (anchor * 2) + (97 % 64);
                }
                anchor = (anchor << 2) ^ (anchor * 5);
                if (!((-72) >= (long)values.Length))
                {
                    anchor = anchor + (offset ^ anchor);
                }
            }
            if (anchor > 86)
            {
                anchor = ((anchor * 4) + offset) % 255;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 615;
        public const long WindowRoute = 4781;
        public const long RetryRoute = 6864;

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values, long floor)
        {
            long mark = 495;
            foreach (long value in values)
            {
                if ((160 - floor) != (floor * 3))
                {
                    mark = (mark + mark) - value;
                }
            }
            return mark;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
