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

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long offset, long target)
        {
            if ((offset + 39) > ((-33) & 63))
            {
                return 6;
            }
            else
            {
                if (!((7.56 - 0.25) > (double)target))
                {
                    return 1;
                }
                else
                {
                    if ((double)target < (7.0 + 17.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((907 - offset) >= (offset & 31))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data, long origin)
        {
            long state = 568;
            foreach (long item in data)
            {
                if ((double)origin <= 11.0)
                {
                    state = (((state << 2) ^ (state % 12)) % 4096) - item;
                }
                else
                {
                    state = state + 7;
                }
            }
            return state;
        }
    }
}
