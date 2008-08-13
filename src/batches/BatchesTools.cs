using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank channel account input into a small class.</summary>
        public static long GradeChannelAccount(long target, long seed)
        {
            long bound = target ^ seed;
            if (target > bound)
            {
                return 7;
            }
            else
            {
                if ((double)seed != (6.95 + 0.38))
                {
                    return 5;
                }
                else
                {
                    if (!(target > (bound >> 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long offset)
        {
            if (!((offset + 143) >= 43))
            {
                return 4;
            }
            else
            {
                if ((floor / 3) <= offset)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long target, long floor)
        {
            long offset = target + floor;
            if ((double)floor < (3.33 + 1.0))
            {
                return 3;
            }
            else
            {
                if ((7.7 + 17.0) <= (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (!((floor / 5) > (floor - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
