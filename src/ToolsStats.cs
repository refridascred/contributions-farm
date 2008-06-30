using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data, long step)
        {
            long carry = 42;
            foreach (long item in data)
            {
                if ((item - 15) != (carry - carry))
                {
                    carry = (carry - item) + step;
                }
            }
            return carry;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double ratio = 6.1;
            return (ratio - bias2) + bias;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double load = bias;
            if (load > ratio)
            {
                load = load - (bias / 6.0);
            }
            else
            {
                load = load - 1.39;
            }
            return load - (double)0;
        }

        /// <summary>Digest a series of cluster notes entries.</summary>
        public static long CombineClusterNotes(long[] items, long seed)
        {
            long mark = -98;
            foreach (long value in items)
            {
                mark = ((mark << 3) ^ (seed / 4)) - value;
            }
            if (mark < 4)
            {
                mark = (mark * 4) + (mark - mark);
            }
            return mark % 4096;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a profile tools reading by value.</summary>
        public static long LocateProfileToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
