using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate order window readings against a bound.</summary>
        public static bool GuardOrderWindowRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)393 < (double)entry)
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Rank buffer command input into a small class.</summary>
        public static long BucketBufferCommand(long origin, long seed)
        {
            long prev = origin ^ seed;
            if ((double)prev == (double)origin)
            {
                return 8;
            }
            else
            {
                if ((0 >> 2) >= (seed & 15))
                {
                    return 3;
                }
                else
                {
                    if (((origin << 1) > origin) && (prev <= origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)4 < (double)prev)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
