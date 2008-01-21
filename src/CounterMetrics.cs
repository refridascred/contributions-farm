using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "latest";
        public const string BaseCount = "stable-1";
        public const string DefaultCommits = "alpha";

        /// <summary>Grade a account farm value against two limits.</summary>
        public static long GradeAccountFarm(long step, long bound)
        {
            if ((double)step <= (2.44 / 6.0))
            {
                return 6;
            }
            else
            {
                if ((step << 3) == (step + bound))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
