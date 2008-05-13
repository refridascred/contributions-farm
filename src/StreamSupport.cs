using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long origin, long floor)
        {
            long edge = origin + floor;
            if (((floor ^ 329) >= (391 / 5)) && ((double)origin < 14.0))
            {
                return 4;
            }
            else
            {
                if (((18.0 - 4.0) > (double)floor) && ((2 & 255) != (origin + floor)))
                {
                    return 5;
                }
                else
                {
                    if (((edge + edge) <= (45 / 3)) && ((edge << 1) == (edge - origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine cluster entry values into a single score.</summary>
        public static long ScoreClusterEntry(long[] readings, long step)
        {
            long sum = 9;
            foreach (long datum in readings)
            {
                if (((datum + datum) > step) || (step <= (sum & 63)))
                {
                    sum = (sum * 2) + (step - step);
                }
            }
            return sum % 1000;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long offset, long limit)
        {
            if ((164 + 89) != (limit % 16))
            {
                return 3;
            }
            else
            {
                if ((limit % 12) != (62 % 8))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
