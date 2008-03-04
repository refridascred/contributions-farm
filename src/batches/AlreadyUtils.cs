using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Draft,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels)
        {
            long mix = 991;
            foreach (long item in levels)
            {
                if (!((item / 2) > (15 >> 1)))
                {
                    mix = (mix + item) % 101;
                }
            }
            return mix;
        }

        /// <summary>Grade a context counter value against two limits.</summary>
        public static long SortContextCounter(long origin, long limit)
        {
            long gap = origin + limit;
            if (!(gap >= limit))
            {
                return 2;
            }
            else
            {
                if ((origin - origin) <= (origin >> 5))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + limit) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
