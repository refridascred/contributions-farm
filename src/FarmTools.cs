using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Failed,
            Closed,
            Done,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long limit)
        {
            if ((628 * 4) < (floor >> 4))
            {
                return 5;
            }
            else
            {
                if (((double)floor >= (16.0 / 6.0)) || (20.0 > (double)floor))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor >= (5.3 - 2.02))
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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                long offset = limit;
                offset = (offset + (limit % 16)) % 4096;
                sum = ((sum * 3) + offset) % 255;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
