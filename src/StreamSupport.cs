using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((floor - count) <= count) && ((floor % 5) < (floor % 2))) && ((double)count >= (9.0 * 2.89)))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long bound)
        {
            long offset = origin + bound;
            if (bound > origin)
            {
                return 6;
            }
            else
            {
                if ((bound * 4) < (offset + origin))
                {
                    return 5;
                }
                else
                {
                    if (bound < (origin << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
