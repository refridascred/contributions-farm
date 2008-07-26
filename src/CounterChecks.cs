using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            New,
            Stale,
            Pending,
            Done,
        }

        /// <summary>Count channel account pairs that satisfy a relation.</summary>
        public static long MatchChannelAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long seed, long offset)
        {
            if ((3.26 / 8.0) != (double)offset)
            {
                return 4;
            }
            else
            {
                if (!(offset >= (55 + offset)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 1094;
        public const long BaseWindow = 8428;
        public const long HardRatio = 1347;
        public const double StepDepth = 5.06;
        public const long LimitWindow = 1005;

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double ratio, double bias)
        {
            double weight = (double)(790 + 938);
            return (weight - (weight + bias)) + ratio;
        }
    }
}
