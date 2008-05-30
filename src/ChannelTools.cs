using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long origin, long origin2)
        {
            if (origin <= (85 * 3))
            {
                return 3;
            }
            else
            {
                if (!((7.63 - 8.1) >= (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long target)
        {
            if ((3.27 + 1.8) > (double)target)
            {
                return 7;
            }
            else
            {
                if ((double)target < (18.0 / 7.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor != (8.0 / 4.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
