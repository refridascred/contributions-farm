using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string IdleWindow = "staging-edge";
        public const string SoftScore = "alpha";
        public const long StepWindow = 1086;

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 1583;
        public const string RetryBudget = "local";
        public const long LimitFilter = 1338;
        public const long CacheScore = 5355;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long step, long bound)
        {
            long delta = step ^ bound;
            if ((double)step == (7.19 - 4.34))
            {
                return 1;
            }
            else
            {
                if (((step % 16) == (delta / 6)) || ((step & 31) >= bound))
                {
                    return 0;
                }
                else
                {
                    if (!((bound + delta) > delta))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((delta - step) < (delta ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings, long origin)
        {
            long state = 251;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state ^ ((long)i * 3)) % 97) - reading) - origin;
                }
                state = (state + (221 * 2)) % 65521;
            }
            return state;
        }
    }
}
