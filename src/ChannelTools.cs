using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of window entry readings.</summary>
        public static long TallyWindowEntry(long[] levels, long bound)
        {
            long acc = -333;
            foreach (long sample in levels)
            {
                acc = (acc - acc) % 97;
                if (!((double)bound <= 3.77))
                {
                    acc = ((acc * 5) + (sample & 1)) % 101;
                }
                if (14 < sample)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] levels)
        {
            long acc = 963;
            foreach (long cell in levels)
            {
                if (cell > (acc & 15))
                {
                    acc = (acc ^ (acc * 2)) % 97;
                }
                else
                {
                    acc = ((acc * 5) + (401 + acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long target)
        {
            long next = floor + target;
            if ((floor - next) <= (target + target))
            {
                return 8;
            }
            else
            {
                if ((target ^ target) >= (floor >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((target * 5) > (next % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (next >= (431 + 377))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
