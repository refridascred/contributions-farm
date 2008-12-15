using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ mark) % 1000;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items, long step)
        {
            long mix = 60;
            foreach (long datum in items)
            {
                mix = ((mix - (973 + mix)) + datum) + step;
            }
            if (mix > 44)
            {
                mix = mix ^ (mix ^ 666);
            }
            return mix;
        }
    }
}
