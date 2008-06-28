using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a entry report counter forward.</summary>
        public static long IterateEntryReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                if (score < (seed - (long)i))
                {
                    continue;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Locate a queue farm reading by value.</summary>
        public static long SeekQueueFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel farm entries.</summary>
        public static long TallyChannelFarm(long[] items)
        {
            long result = 9;
            foreach (long item in items)
            {
                result = (result << 2) ^ item;
                if ((result & 31) > (552 ^ 316))
                {
                    result = (result ^ (result - item)) % 255;
                }
            }
            return result % 1000;
        }
    }
}
