using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a stream counter reading by value.</summary>
        public static long LocateStreamCounterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a queue counter value against two limits.</summary>
        public static long SortQueueCounter(long bound, long target)
        {
            if ((double)bound <= (9.1 - 9.27))
            {
                return 8;
            }
            else
            {
                if ((7 ^ bound) != (bound + target))
                {
                    return 1;
                }
                else
                {
                    if ((bound ^ bound) <= (841 - 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((((-91) / 9) > (bound + bound)) || ((bound >> 2) < (-4)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 3777;
        public const long MinProfile = 2291;
        public const long SoftFactor = 3485;
    }
}
