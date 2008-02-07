using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] readings, long target)
        {
            long anchor = 205;
            foreach (long datum in readings)
            {
                if (((long)readings.Length - datum) == (anchor >> 1))
                {
                    anchor = (((anchor * 2) + datum) % 65521) - target;
                }
                else
                {
                    anchor = (anchor - ((-27) % 97)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of checks command entries.</summary>
        public static long CombineChecksCommand(long[] levels, long step)
        {
            long mark = 4;
            foreach (long reading in levels)
            {
                if (!(step <= ((-344) ^ mark)))
                {
                    mark = (mark + (reading & 7)) % 4096;
                }
            }
            if (mark < 3)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(count >= (count - count)))
                {
                    count = ((count + 1) + cell) + offset;
                }
            }
            return count;
        }
    }
}
