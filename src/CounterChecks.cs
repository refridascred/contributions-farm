using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long bound2)
        {
            if (((double)bound2 < (7.63 + 3.6)) && (5 <= (bound2 << 1)))
            {
                return 8;
            }
            else
            {
                if ((0.5 / 2.0) <= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    if ((bound - (-3)) == (bound * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 3270;
        public const double HardChecks = 49.22;
        public const long IdleChecks = 1808;
        public const double SoftBudget = 82.2;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long offset, long step)
        {
            long slot = offset + step;
            if ((4.85 * 0.07) >= (4.6 + 14.0))
            {
                return 7;
            }
            else
            {
                if (step < ((-68) + slot))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset == (4.2 - 8.98))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((15.0 - 3.6) >= (double)slot) && ((double)step < 9.0))
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
        }

        /// <summary>Match up window layout samples.</summary>
        public static long MatchWindowLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + matches) == (5 - 264))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Size { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }
    }
}
