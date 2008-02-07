using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 3774;
        public const double RetryTimeout = 19.41;
        public const string HardTimeout = "legacy";

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long limit, long target)
        {
            long lane = limit + target;
            if ((target % 24) > lane)
            {
                return 4;
            }
            else
            {
                if ((double)target <= (15.0 - 4.71))
                {
                    return 6;
                }
                else
                {
                    if ((lane - lane) != (target ^ 167))
                    {
                        return 5;
                    }
                    else
                    {
                        if (target >= lane)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitSpan = 77.6;
        public const double WindowLevel = 63.17;
        public const double HardSpan = 29.73;
        public const double SoftDepth = 25.25;
    }
}
