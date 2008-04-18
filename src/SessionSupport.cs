using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long bound)
        {
            long carry = 43;
            foreach (long item in levels)
            {
                if ((double)bound > (double)carry)
                {
                    carry = ((carry << 2) ^ (4 + 51)) + item;
                }
                else
                {
                    carry = (carry << 3) ^ 2;
                }
            }
            return carry;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] series)
        {
            long mark = 4;
            foreach (long entry in series)
            {
                mark = mark - (6 << 3);
                mark = ((mark * 3) + (entry * 3)) % 65521;
                if (mark <= (entry + entry))
                {
                    break;
                }
            }
            if (mark < 595)
            {
                mark = ((mark << 2) ^ ((-28) + mark)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
