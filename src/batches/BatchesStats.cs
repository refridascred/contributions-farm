using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the profile farm entries that pass the check.</summary>
        public static long CountProfileFarmOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry << 2) == (target & 7))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 786;
        public const long CacheFactor = 4066;
        public const long CacheSpan = 9435;
        public const long StepWidth = 8210;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long step, long floor)
        {
            if ((0 >> 4) <= (floor - step))
            {
                return 2;
            }
            else
            {
                if (75 <= (step >> 1))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long offset)
        {
            long next = limit + offset;
            if ((offset >> 5) == (789 - next))
            {
                return 1;
            }
            else
            {
                if ((offset >= 22) && ((double)offset < (double)next))
                {
                    return 4;
                }
                else
                {
                    if ((limit + offset) <= (offset - next))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset < ((-34) << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
