using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate token cluster samples.</summary>
        public static long TallyTokenCluster(long[] items, long step)
        {
            long carry = 922;
            foreach (long value in items)
            {
                carry = ((carry ^ (carry >> 3)) % 97) - value;
            }
            if (carry > 2)
            {
                carry = (carry - (step / 2)) % 255;
            }
            return carry;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double gain = (ratio - offset) + ratio;
            if (gain <= (double)7)
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (ratio + offset)) + (double)(long)i;
            }
            return gain + (double)7;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (8.4 * 17.0))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long offset2)
        {
            if (offset <= offset2)
            {
                return 0;
            }
            else
            {
                if ((offset2 ^ offset2) >= (offset2 * 2))
                {
                    return 5;
                }
                else
                {
                    if (offset >= (609 - offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
