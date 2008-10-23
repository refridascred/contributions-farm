using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultCount = "latest-1";
        public const double BatchCount = 53.97;
        public const string DefaultSpan = "open-v2";
        public const long WindowGraph = 8718;
        public const long SoftGraph = 8554;

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 92.73;
        public const double StepCache = 45.51;
        public const long BaseCache = 6473;
        public const long IdleCache = 3155;

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double bias = scale;
            if (bias < scale)
            {
                bias = (bias - 7.77) - offset;
            }
            else
            {
                bias = bias + scale;
            }
            return bias + (double)615;
        }
    }
}
