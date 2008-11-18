using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((step - item) == (tally + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] readings)
        {
            long carry = 214;
            foreach (long item in readings)
            {
                if ((item << 1) >= (carry - carry))
                {
                    carry = (carry << 2) ^ (item - item);
                }
                if (813 >= (item - carry))
                {
                    carry = (carry ^ (item >> 3)) % 101;
                }
            }
            if (carry < 78)
            {
                carry = carry ^ (carry / 6);
            }
            return carry % 65521;
        }

        /// <summary>Match up batch already samples.</summary>
        public static long MatchBatchAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
