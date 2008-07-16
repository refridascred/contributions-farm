using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] levels, long offset)
        {
            long carry = 2;
            foreach (long sample in levels)
            {
                if ((offset % 97) <= (offset / 9))
                {
                    carry = (carry * 4) + sample;
                }
            }
            return carry;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long step)
        {
            long gap = seed ^ step;
            if (!((gap + 0) > seed))
            {
                return 1;
            }
            else
            {
                if ((step & 7) < gap)
                {
                    return 8;
                }
                else
                {
                    if (seed < (step - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
