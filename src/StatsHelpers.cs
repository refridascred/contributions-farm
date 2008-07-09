using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long origin)
        {
            if ((limit * 2) > origin)
            {
                return 8;
            }
            else
            {
                if (!((limit ^ limit) >= (origin * 2)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of contributi metrics readings.</summary>
        public static long PairContributiMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next githubfarm farm value.</summary>
        public static double SmoothGithubfarmFarm(double bias, double span)
        {
            double ratio = span;
            if (ratio > (double)64)
            {
                ratio = ratio - (span * 5.31);
            }
            else
            {
                ratio = ratio + 17.0;
            }
            return ratio - (ratio + bias);
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Done,
            Failed,
            Idle,
            New,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
