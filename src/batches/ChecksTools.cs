using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long limit)
        {
            long bound = offset - limit;
            if (!((double)offset >= 20.0))
            {
                return 7;
            }
            else
            {
                if ((limit ^ limit) <= (limit ^ bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (9.6 - 4.5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset >> 1) < offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = (result - (result * 5)) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long offset)
        {
            if (!((double)limit <= (7.4 * 12.0)))
            {
                return 2;
            }
            else
            {
                if (((limit >> 3) > offset) && ((13 << 3) <= (offset + 99)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
