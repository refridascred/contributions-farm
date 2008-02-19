using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count contributi format pairs that satisfy a relation.</summary>
        public static long PairContributiFormatCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
