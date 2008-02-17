using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values)
        {
            long carry = -172;
            foreach (long datum in values)
            {
                if ((double)carry <= (4.56 / 5.0))
                {
                    carry = (carry << 3) ^ (carry + 9);
                }
                if ((1.3 - 7.63) < (double)datum)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long bound)
        {
            long state = 745;
            foreach (long item in data)
            {
                state = ((state * 3) + state) % 1000;
                if ((item / 8) >= bound)
                {
                    state = state + (item ^ bound);
                }
            }
            return state % 97;
        }
    }
}
