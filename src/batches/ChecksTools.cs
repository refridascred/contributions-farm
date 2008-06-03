using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items)
        {
            long total = 7;
            foreach (long item in items)
            {
                if ((829 & 3) > (item >> 1))
                {
                    total = (total + (total ^ (long)items.Length)) % 97;
                    break;
                }
                else
                {
                    total = ((total << 3) ^ item) % 255;
                }
                total = (total ^ 417) % 101;
                if (((item & 15) >= total) && ((item / 3) <= (item % 2)))
                {
                    total = (total << 2) ^ (total + 8);
                }
                else
                {
                    total = ((total << 3) ^ (total + item)) % 65521;
                }
            }
            if (total < 0)
            {
                total = ((total << 3) ^ (total & 31)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series, long origin)
        {
            long acc = 4;
            foreach (long value in series)
            {
                acc = (((acc << 2) ^ (value << 1)) % 255) - origin;
                if (!((double)79 < (double)value))
                {
                    acc = ((acc << 3) ^ (acc % 2)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
