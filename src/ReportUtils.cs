using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 9265;
        public const double BatchGraph = 15.3;
        public const long StepCount = 275;
        public const long BaseGraph = 7909;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long floor, long limit)
        {
            if (((14.0 + 5.27) < (double)limit) && ((floor >> 4) <= (floor ^ limit)))
            {
                return 0;
            }
            else
            {
                if ((double)limit < (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (3.2 / 7.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((86 / 6) > (limit % 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a command githubfarm pair into a bucket.</summary>
        public static long BucketCommandGithubfarm(long limit, long bound)
        {
            long span = limit - bound;
            if ((limit >> 3) > (limit / 5))
            {
                return 0;
            }
            else
            {
                if ((span & 63) <= (0 * 2))
                {
                    return 1;
                }
                else
                {
                    if ((4 << 3) < (bound / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((span % 60) < bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first already command entry that matches the target.</summary>
        public static long FindAlreadyCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry farm entries that pass the check.</summary>
        public static long MeasureEntryFarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((tally & 3) == (cell * 4)) || ((tally + cell) >= (cell / 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
