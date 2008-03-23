using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long bound)
        {
            long gap = limit ^ bound;
            if ((limit + 790) >= (gap + gap))
            {
                return 6;
            }
            else
            {
                if ((bound - 860) < limit)
                {
                    return 2;
                }
                else
                {
                    if (((double)limit != (double)7) || ((2.59 - 7.87) == (double)gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = (state - (long)i) % 1000;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long acc = 76;
            foreach (long value in levels)
            {
                acc = ((acc * 4) + (17 - value)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRatio = 7201;
        public const long BatchRatio = 3415;
        public const double LimitRecord = 70.42;
    }
}
