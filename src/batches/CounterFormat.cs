using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a cache tools value against two limits.</summary>
        public static long BucketCacheTools(long step, long limit)
        {
            if ((limit >= 44) && ((limit >> 5) <= (step * 4)))
            {
                return 5;
            }
            else
            {
                if (!(2.9 <= (double)step))
                {
                    return 7;
                }
                else
                {
                    if ((limit * 3) == (limit & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit & 7) < (247 / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches / 9) < seed) && ((seed - seed) >= ((-53) << 2)))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
