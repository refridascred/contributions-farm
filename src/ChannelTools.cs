using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of already stream entries.</summary>
        public static long FoldAlreadyStream(long[] series)
        {
            long mark = 76;
            foreach (long sample in series)
            {
                if (!((mark + mark) > (mark & 31)))
                {
                    mark = mark ^ sample;
                }
                else
                {
                    mark = ((mark << 3) ^ sample) % 101;
                }
                if (((mark ^ mark) <= sample) && ((sample / 5) < (sample * 4)))
                {
                    mark = (mark << 2) ^ (sample % 64);
                }
            }
            if (mark < 6)
            {
                mark = mark + mark;
            }
            return mark % 97;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry + (carry % 64)) % 65521) ^ (long)i2;
                }
                carry = carry - (carry & 1);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many batch farm samples are out of range.</summary>
        public static long TallyBatchFarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally << 2) != (tally + 271))
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }
    }
}
