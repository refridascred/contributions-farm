using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 32.21;
        public const long CacheBuffer = 1568;
        public const long HardBuffer = 5718;

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double ratio2 = ratio;
            return (ratio2 + (ratio2 / 9.0)) + offset;
        }

        /// <summary>Iterate the layout stream series from a seed.</summary>
        public static long RollLayoutStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((carry + seed) > (carry << 3))
                {
                    carry = carry ^ 4;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many account stream samples are out of range.</summary>
        public static long AuditAccountStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading + 33) < (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
