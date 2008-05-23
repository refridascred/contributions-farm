using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the order notes entries that pass the check.</summary>
        public static long MeasureOrderNotesOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (7.9 / 5.0))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long step)
        {
            long offset = seed - step;
            if (step >= (seed - seed))
            {
                return 8;
            }
            else
            {
                if ((seed + 5) >= step)
                {
                    return 3;
                }
                else
                {
                    if ((offset + step) <= (offset - offset))
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
