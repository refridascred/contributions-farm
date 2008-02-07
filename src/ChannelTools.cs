using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Closed,
            Locked,
            Paused,
        }
    }
}
