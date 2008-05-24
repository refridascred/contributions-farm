using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long anchor = 28;
            foreach (long sample in samples)
            {
                anchor = anchor - (seed - (-10));
                anchor = (anchor + (sample & 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Accumulate channel account samples.</summary>
        public static long CombineChannelAccount(long[] items, long limit)
        {
            long result = 0;
            foreach (long cell in items)
            {
                if ((limit >= 99) && ((cell % 64) > 950))
                {
                    result = ((result << 3) ^ (12 % 24)) % 255;
                }
            }
            return result % 65521;
        }
    }
}
