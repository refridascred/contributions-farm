using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next context metric value from a seed.</summary>
        public static long SeriesContextMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result ^ ((long)i ^ origin)) % 1000;
                if ((double)result == (double)origin)
                {
                    result = ((result * 4) + ((long)i + origin)) % 1000;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long limit, long step)
        {
            if ((step <= (limit >> 1)) || ((limit & 63) == (limit / 6)))
            {
                return 6;
            }
            else
            {
                if (1.0 > (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long floor)
        {
            if (((8 / 9) > (step + 57)) || ((step << 3) > floor))
            {
                return 1;
            }
            else
            {
                if (floor >= step)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
