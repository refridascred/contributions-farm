using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long mark = 0;
            foreach (long entry in readings)
            {
                mark = (((mark << 3) ^ (127 << 3)) % 65521) - entry;
                if ((mark + mark) >= (mark % 5))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark * 3) + (mark + 7);
            }
            return mark;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            if ((bound + bound) <= origin)
            {
                return 1;
            }
            else
            {
                if (bound < (bound / 2))
                {
                    return 7;
                }
                else
                {
                    if (786 <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up layout report samples.</summary>
        public static long OverlapLayoutReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
