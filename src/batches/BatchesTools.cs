using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long limit, long target)
        {
            long diff = limit - target;
            if ((8.01 - 16.0) <= (double)diff)
            {
                return 0;
            }
            else
            {
                if (((limit % 64) < (1 + target)) && ((double)target <= (11.0 + 9.2)))
                {
                    return 5;
                }
                else
                {
                    if ((8.0 + 10.0) < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((7.04 * 6.3) >= (double)limit) && ((limit / 3) >= (diff << 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 2220;
        public const double IdleRatio = 4.31;
        public const double CacheLevel = 5.88;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((888 % 12) < seen))
                {
                    seen = ((seen + 3) + datum) - origin;
                }
            }
            return seen;
        }
    }
}
