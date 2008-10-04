using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a checks queue pair into a bucket.</summary>
        public static long SortChecksQueue(long floor, long step)
        {
            long cur = floor + step;
            if ((floor + 619) < (cur + floor))
            {
                return 2;
            }
            else
            {
                if (((step + cur) < cur) && (step > (floor << 1)))
                {
                    return 1;
                }
                else
                {
                    if ((floor & 255) != (cur / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((cur ^ cur) >= (floor ^ floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((-786) - sample) <= (tally ^ (-432)))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Match up stream commits samples.</summary>
        public static long CompareStreamCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
