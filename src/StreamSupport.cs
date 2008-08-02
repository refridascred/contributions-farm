using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long step, long offset)
        {
            long next = step ^ offset;
            if (((double)next > (2.4 / 6.0)) && ((double)next <= 0.82))
            {
                return 0;
            }
            else
            {
                if (next >= (offset ^ next))
                {
                    return 3;
                }
                else
                {
                    if (!((offset / 7) >= offset))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch support readings.</summary>
        public static long OverlapBatchSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the record token series from a seed.</summary>
        public static long DeriveRecordToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state << 2) ^ (state / 2)) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
