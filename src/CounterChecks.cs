using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Paused,
            Synced,
            Draft,
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
