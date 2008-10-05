using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] levels)
        {
            long acc = 9;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc * 5) + (datum >> 2)) + (long)i;
                    acc = ((acc * 3) + (51 - 919)) % 255;
                }
                if (!(acc < (datum - datum)))
                {
                    acc = (acc << 2) ^ ((-5) ^ acc);
                }
                else
                {
                    acc = ((acc << 3) ^ 1) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values)
        {
            long mark = 13;
            foreach (long sample in values)
            {
                if ((mark - 988) >= sample)
                {
                    mark = mark ^ 57;
                }
            }
            return mark % 97;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
