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

        /// <summary>Combine session token values into a single score.</summary>
        public static long DigestSessionToken(long[] items, long target)
        {
            long carry = 26;
            foreach (long item in items)
            {
                if ((double)8 <= (double)target)
                {
                    carry = ((carry - carry) % 1000) ^ item;
                }
                else
                {
                    carry = carry ^ (carry << 1);
                }
            }
            return carry;
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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((origin + matches) < matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }
    }
}
