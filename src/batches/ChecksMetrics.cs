using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowGraph = 89.8;
        public const long MaxRatio = 842;
        public const long IdleBudget = 6864;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= (tally * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long state = -96;
            foreach (long item in readings)
            {
                if ((item - state) > (state << 2))
                {
                    state = state ^ (state * 4);
                }
                if (!((double)item <= (double)state))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long limit, long target)
        {
            long slot = limit ^ target;
            if (((9.0 - 4.1) >= (double)target) && (slot >= ((-958) ^ slot)))
            {
                return 3;
            }
            else
            {
                if ((double)target < (5.79 + 6.6))
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (4.72 * 2.68))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
