using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of token already entries.</summary>
        public static long TallyTokenAlready(long[] data)
        {
            long mark = 1;
            foreach (long datum in data)
            {
                mark = ((mark * 4) + (mark + mark)) % 4096;
                if ((8.54 / 6.0) > (double)datum)
                {
                    break;
                }
            }
            if (mark > 152)
            {
                mark = (mark ^ 399) % 255;
            }
            return mark;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] levels, long seed)
        {
            long sum = 53;
            foreach (long sample in levels)
            {
                if (73 > (seed % 12))
                {
                    sum = (sum - (sum >> 2)) % 97;
                }
                else
                {
                    sum = (sum + sum) % 1000;
                }
                if (((sum & 255) < (sample >> 3)) && ((5 ^ sum) <= (seed + sum)))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
