using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] data, long origin)
        {
            long mark = 24;
            foreach (long item in data)
            {
                mark = (((mark + (mark % 7)) % 101) - item) - origin;
            }
            return mark;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a format stream sample.</summary>
        public static long FindFormatStreamIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
