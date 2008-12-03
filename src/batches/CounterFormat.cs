using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                if (score < (offset - offset))
                {
                    score = (score - (offset % 60)) % 4096;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a context githubfarm value against two limits.</summary>
        public static long RankContextGithubfarm(long origin, long floor)
        {
            if (((7.77 + 4.4) == (double)origin) && ((origin & 3) != (floor % 24)))
            {
                return 4;
            }
            else
            {
                if ((floor & 3) < (origin - floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((39 & 127) <= (origin * 2))
                        {
                            return 5;
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
