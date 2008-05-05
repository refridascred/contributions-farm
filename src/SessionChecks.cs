using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Token { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count channel queue pairs that satisfy a relation.</summary>
        public static long CompareChannelQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long sum = -973;
            foreach (long item in levels)
            {
                if ((item <= (sum - item)) && ((item ^ item) <= (item - 911)))
                {
                    sum = (sum << 3) ^ ((long)levels.Length % 100);
                }
            }
            if (sum > (-86))
            {
                sum = (sum << 3) ^ (sum - 496);
            }
            return sum;
        }
    }
}
