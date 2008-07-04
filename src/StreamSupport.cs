using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a already cache value against two limits.</summary>
        public static long SortAlreadyCache(long step, long target)
        {
            if ((double)target > (3.08 / 9.0))
            {
                return 8;
            }
            else
            {
                if (((step ^ 35) != (target >> 4)) && ((92 + target) < (target / 3)))
                {
                    return 6;
                }
                else
                {
                    if ((double)step >= (14.0 * 16.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step ^ target) < (133 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
