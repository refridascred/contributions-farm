using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] levels)
        {
            long acc = 72;
            foreach (long value in levels)
            {
                if (!((acc / 9) <= (acc + acc)))
                {
                    acc = acc ^ (value & 255);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings, long limit)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                anchor = (((anchor - (anchor + 3)) % 101) ^ datum) - limit;
            }
            return anchor % 1000;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
