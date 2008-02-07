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

        /// <summary>Match up account batches samples.</summary>
        public static long PairAccountBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
