using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a commits order pair into a bucket.</summary>
        public static long GradeCommitsOrder(long offset, long step)
        {
            if ((double)offset <= (8.2 + 19.0))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) >= (offset - step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (13.0 + 8.7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.0 / 2.0) == (double)offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long offset)
        {
            long bound = seed - offset;
            if (seed >= (bound - offset))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) <= (bound - 489))
                {
                    return 5;
                }
                else
                {
                    if (offset <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - 617) != (bound + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepBudget = 6633;
        public const string MinEditor = "latest-1";
        public const long StepTimeout = 5731;

        /// <summary>Derive the next metric filter value from a seed.</summary>
        public static long RollMetricFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((9.3 / 8.0) >= (double)sum) && ((double)(long)i != (9.4 * 7.58)))
                {
                    sum = (sum ^ (sum / 5)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
