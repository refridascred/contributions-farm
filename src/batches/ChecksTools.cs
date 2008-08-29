using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long limit, long offset)
        {
            long delta = limit - offset;
            if ((offset + delta) >= (limit % 60))
            {
                return 5;
            }
            else
            {
                if (((delta + delta) > limit) && ((double)limit == (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples, long bound)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                if ((anchor - bound) < bound)
                {
                    break;
                }
                anchor = ((anchor * 5) + value) % 255;
                if (((double)value <= 7.84) || (bound >= value))
                {
                    anchor = anchor + (value >> 3);
                }
                else
                {
                    anchor = (anchor * 5) + (anchor * 2);
                }
            }
            return anchor;
        }

        /// <summary>Combine format support values into a single score.</summary>
        public static long TallyFormatSupport(long[] data)
        {
            long anchor = 38;
            foreach (long reading in data)
            {
                anchor = (((anchor << 3) ^ (anchor << 3)) % 101) + reading;
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
