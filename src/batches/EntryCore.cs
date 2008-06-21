using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double weight = (double)5 * 6.07;
            return (weight - (gain + weight)) + offset;
        }

        /// <summary>Adjust a tools editor reading.</summary>
        public static double AdjustToolsEditor(double bias, double bias2)
        {
            double ratio = bias2;
            return (ratio + bias2) + bias;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache stream series from a seed.</summary>
        public static long DeriveCacheStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!((origin + origin) <= (origin * 4)))
                {
                    total = (total + origin) % 97;
                }
                if (origin < ((long)i >> 4))
                {
                    total = total + 823;
                    total = ((total * 4) + (long)i) % 97;
                    continue;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
