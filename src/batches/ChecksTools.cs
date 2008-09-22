using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph route readings.</summary>
        public static long DigestGraphRoute(long[] data, long floor)
        {
            long mark = -540;
            foreach (long reading in data)
            {
                mark = (((mark ^ (mark * 4)) % 65521) ^ reading) + floor;
                mark = (mark ^ mark) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 6344;
        public const long BurstSession = 4613;
        public const long BurstTimeout = 676;
    }
}
