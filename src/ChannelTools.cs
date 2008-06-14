using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first checks record entry that matches the target.</summary>
        public static long LookupChecksRecordIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples)
        {
            long mark = -3;
            foreach (long value in samples)
            {
                if ((0.08 <= (double)value) || ((1.16 - 7.01) <= (double)value))
                {
                    mark = (mark + 247) % 101;
                }
                else
                {
                    long cur = (value + mark) + mark;
                    mark = (mark * 5) + (cur + 0);
                }
                mark = (mark + (mark + mark)) % 65521;
            }
            if (mark < 93)
            {
                mark = (mark - (mark - mark)) % 255;
            }
            return mark % 1000;
        }
    }
}
