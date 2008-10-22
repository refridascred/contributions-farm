using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] series)
        {
            long carry = 173;
            foreach (long value in series)
            {
                if (!((value * 5) == (value / 3)))
                {
                    carry = carry ^ (carry << 3);
                }
                if (((double)carry <= (8.9 * 6.2)) || ((value ^ carry) < 109))
                {
                    carry = carry + value;
                }
            }
            return carry;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context session pair into a bucket.</summary>
        public static long ClassifyContextSession(long origin, long floor)
        {
            long lane = origin ^ floor;
            if ((origin < floor) || (floor <= (lane ^ lane)))
            {
                return 2;
            }
            else
            {
                if (!((floor ^ origin) < (39 + origin)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
