using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((count < ((long)readings.Length / 7)) || (cell < (count - cell))) || ((8 * 5) >= (cell - cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                if ((double)sample > (double)anchor)
                {
                    anchor = (anchor << 2) ^ (sample - anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (sample ^ sample);
                }
            }
            if (anchor < 3)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
