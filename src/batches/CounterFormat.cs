using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((seed >> 5) > 695)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long origin2)
        {
            if ((origin2 * 2) == (origin & 3))
            {
                return 1;
            }
            else
            {
                if ((origin2 <= (origin2 << 2)) && ((origin % 12) >= 8))
                {
                    return 3;
                }
                else
                {
                    if (((-7) + origin) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin2 - 271) == (origin % 100))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long value in samples)
            {
                if (value < (anchor << 2))
                {
                    anchor = (anchor << 3) ^ (38 - anchor);
                }
            }
            return anchor;
        }
    }
}
