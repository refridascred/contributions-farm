using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload stats counter forward.</summary>
        public static long SeriesPayloadStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (sum + sum)) % 97;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum ^ (seed + seed)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings)
        {
            long mix = 996;
            foreach (long entry in readings)
            {
                mix = (((mix * 5) + mix) % 255) + entry;
            }
            return mix;
        }

        /// <summary>Locate a command record reading by value.</summary>
        public static long FindCommandRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
