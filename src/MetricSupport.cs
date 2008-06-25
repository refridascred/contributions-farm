using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value < (value ^ (-7))) && !(2 < (3 + count)))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftLevel = 1273;
        public const long MinFilter = 9395;
        public const long MaxFilter = 3974;
        public const long BaseFilter = 3206;
    }
}
