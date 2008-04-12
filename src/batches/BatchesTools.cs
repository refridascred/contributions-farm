using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long target, long offset)
        {
            long delta = target ^ offset;
            if (delta > (505 + delta))
            {
                return 0;
            }
            else
            {
                if ((251 + target) > target)
                {
                    return 8;
                }
                else
                {
                    if ((delta - 84) != (target - (-6)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((15.0 - 3.0) == (double)target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Stale,
            Ready,
        }
    }
}
