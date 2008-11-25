using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] levels, long origin)
        {
            long acc = 201;
            foreach (long cell in levels)
            {
                if ((cell + origin) < cell)
                {
                    acc = acc + (7 << 2);
                    continue;
                }
                if (7 <= (cell / 2))
                {
                    acc = (acc << 2) ^ (cell - origin);
                }
            }
            if (acc > 440)
            {
                acc = (acc + origin) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound - 9) < bound)
                {
                    anchor = ((anchor << 2) ^ (bound << 3)) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
