using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long step, long bound)
        {
            if ((bound - step) > 445)
            {
                return 7;
            }
            else
            {
                if ((bound & 31) == (bound >> 4))
                {
                    return 1;
                }
                else
                {
                    if (((step - (-1)) <= (step << 3)) || ((step + bound) == (step % 97)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Dropped,
            Active,
            Pending,
            Synced,
        }
    }
}
