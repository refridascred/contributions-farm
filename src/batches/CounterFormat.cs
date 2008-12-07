using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a counter channel reading by value.</summary>
        public static long LocateCounterChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long origin)
        {
            if ((origin / 5) == (floor ^ origin))
            {
                return 5;
            }
            else
            {
                if ((2 + origin) == (579 / 7))
                {
                    return 1;
                }
                else
                {
                    if (!((origin ^ (-719)) >= origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen > limit)
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
