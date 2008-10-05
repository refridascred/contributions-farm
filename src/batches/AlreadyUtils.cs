using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((seed - seed) >= (49 + seed))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long limit)
        {
            long offset = floor ^ limit;
            if (limit <= (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((floor & 1) == (limit / 5))
                {
                    return 6;
                }
                else
                {
                    if (((double)limit != (double)floor) || ((limit >> 5) >= (28 - 45)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit << 2) >= (offset ^ floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] items, long origin)
        {
            long result = -73;
            foreach (long entry in items)
            {
                result = (result ^ (entry * 5)) + origin;
            }
            return result % 4096;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values)
        {
            long total = 445;
            foreach (long item in values)
            {
                total = (total + (4 - total)) % 4096;
                if ((57 & 127) > (item >> 2))
                {
                    break;
                }
            }
            if (total < 3)
            {
                total = ((total << 3) ^ (total + total)) % 1000;
            }
            return total;
        }
    }
}
