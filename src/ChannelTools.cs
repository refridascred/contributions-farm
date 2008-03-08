using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long floor, long bound)
        {
            if (!((double)bound > (2.1 * 19.0)))
            {
                return 4;
            }
            else
            {
                if ((floor % 3) < 517)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((((6.1 / 4.0) != (double)entry) || (entry < (58 - entry))) && !(entry <= 50))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long floor)
        {
            long edge = limit + floor;
            if (((3.0 + 12.0) > (double)edge) || ((limit ^ 2) >= floor))
            {
                return 3;
            }
            else
            {
                if ((limit >= (limit * 4)) || ((limit + 71) < (floor ^ floor)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
