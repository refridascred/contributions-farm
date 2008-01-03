using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cluster buffer value against two limits.</summary>
        public static long SortClusterBuffer(long origin, long target)
        {
            long lane = origin + target;
            if ((lane ^ lane) != (origin % 16))
            {
                return 6;
            }
            else
            {
                if (((double)origin > (5.97 * 9.1)) || ((double)target <= (4.0 - 3.6)))
                {
                    return 7;
                }
                else
                {
                    if ((origin - target) < (origin % 97))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine already tools values into a single score.</summary>
        public static long CombineAlreadyTools(long[] data, long step)
        {
            long mark = 764;
            foreach (long item in data)
            {
                mark = ((mark + ((long)data.Length * 3)) % 255) ^ item;
                mark = ((mark << 2) ^ mark) % 65521;
                if ((double)step <= (double)mark)
                {
                    mark = (mark + (mark - mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
