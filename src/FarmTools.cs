using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] data, long seed)
        {
            long anchor = -63;
            foreach (long reading in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((((anchor << 2) ^ (anchor >> 3)) % 4096) ^ (long)i) + seed;
                }
                anchor = (anchor - (reading + anchor)) % 97;
            }
            if (anchor > 770)
            {
                anchor = anchor ^ (-400);
            }
            return anchor;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((41 * 4) > (count - count)) && ((double)cell <= (1.5 - 16.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
