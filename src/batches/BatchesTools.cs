using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long bound, long target)
        {
            if ((bound << 1) <= (bound + target))
            {
                return 6;
            }
            else
            {
                if (((61 & 7) >= target) || ((target + bound) != (bound & 31)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                if (((acc >> 2) <= target) && ((66 * 4) > acc))
                {
                    acc = (acc ^ (7 >> 1)) % 65521;
                }
                else
                {
                    acc = ((acc * 2) + ((long)i * 3)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + count) >= (reading / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
