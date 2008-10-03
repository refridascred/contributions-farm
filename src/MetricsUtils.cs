using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long target, long target2)
        {
            long prev = target - target2;
            if ((double)target == (16.0 / 9.0))
            {
                return 4;
            }
            else
            {
                if ((prev ^ target) < (prev - target2))
                {
                    return 1;
                }
                else
                {
                    if (prev <= (6 + target2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target2 < (target + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] levels)
        {
            long state = 73;
            foreach (long cell in levels)
            {
                state = state - (cell << 2);
                if ((9 ^ cell) != (cell ^ 590))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token report input into a small class.</summary>
        public static long GradeTokenReport(long origin, long limit)
        {
            if ((limit % 5) != (40 * 4))
            {
                return 3;
            }
            else
            {
                if ((limit % 2) <= (limit + origin))
                {
                    return 7;
                }
                else
                {
                    if ((792 + limit) == (891 % 100))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 5680;
        public const string MaxEditor = "cached";
        public const double HardEditor = 81.49;
    }
}
