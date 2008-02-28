using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long bound)
        {
            long bound2 = target - bound;
            if ((target + bound) >= (706 + bound))
            {
                return 0;
            }
            else
            {
                if ((bound + bound) >= bound2)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
