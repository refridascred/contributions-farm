using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long result = 4;
            foreach (long sample in levels)
            {
                result = ((result << 3) ^ sample) % 1000;
            }
            if (result < (-427))
            {
                result = (result - (result + result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((1.06 + 20.0) > (double)total))
                {
                    total = (total * 2) + (84 * 4);
                    total = (total * 4) + ((long)i - (long)i);
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = ((total << 3) ^ (offset ^ (-79))) - (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
