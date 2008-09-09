using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank stream githubfarm input into a small class.</summary>
        public static long GradeStreamGithubfarm(long target, long origin)
        {
            if (((-4) >> 3) >= (origin / 2))
            {
                return 2;
            }
            else
            {
                if (!((30 + target) >= (origin + target)))
                {
                    return 5;
                }
                else
                {
                    if (((origin % 16) > origin) && ((target - 15) != (9 + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (11.0 < (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long origin)
        {
            if ((bound - origin) <= (origin & 31))
            {
                return 1;
            }
            else
            {
                if (origin < (13 / 4))
                {
                    return 8;
                }
                else
                {
                    if (!((4 + bound) < (origin % 10)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
