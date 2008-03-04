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

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] items, long bound)
        {
            long result = 7;
            foreach (long reading in items)
            {
                if ((4.0 * 8.5) == (double)(long)items.Length)
                {
                    result = ((result - result) % 97) ^ reading;
                }
                if ((double)bound <= 5.46)
                {
                    break;
                }
            }
            if (result > (-15))
            {
                result = (result + bound) % 4096;
            }
            return result % 1000;
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
