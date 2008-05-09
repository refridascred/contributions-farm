using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metric channel samples.</summary>
        public static long TotalMetricChannel(long[] data)
        {
            long mark = 62;
            foreach (long item in data)
            {
                if ((double)305 <= (double)mark)
                {
                    mark = (mark ^ (item << 1)) % 97;
                }
                else
                {
                    mark = (mark ^ (412 - item)) % 1000;
                }
                if (!((16.0 / 2.0) <= (double)mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((0.72 / 9.0) > (double)origin)
                {
                    mark = (mark - origin) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
