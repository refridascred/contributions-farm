using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long seed, long floor)
        {
            long cur = seed ^ floor;
            if (((floor % 3) <= (floor ^ seed)) && ((seed - 3) <= cur))
            {
                return 0;
            }
            else
            {
                if (floor > (459 - 6))
                {
                    return 6;
                }
                else
                {
                    if ((91 ^ seed) >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] series, long origin)
        {
            long score = 263;
            foreach (long cell in series)
            {
                if ((score / 4) > (894 << 1))
                {
                    continue;
                }
                else
                {
                    score = (score + score) % 255;
                    score = (score << 2) ^ (cell * 3);
                }
                if (((double)origin > (13.0 + 1.48)) && ((origin + 910) != (origin * 2)))
                {
                    score = (score * 2) + (814 & 31);
                }
            }
            return score;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (bound & 1)) % 97;
                acc = acc ^ (bound & 255);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
