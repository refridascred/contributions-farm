using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long seed)
        {
            long gap = bound + seed;
            if (((double)seed != (double)gap) || (gap < (bound - seed)))
            {
                return 6;
            }
            else
            {
                if (((9.0 - 2.4) != (double)bound) || ((double)bound > (7.0 + 0.91)))
                {
                    return 1;
                }
                else
                {
                    if ((gap + seed) > (bound + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed / 9) == (82 & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftBudget = 36.09;
        public const long IdleLevel = 1368;
        public const double StepRatio = 76.91;
        public const long SoftDepth = 8383;

        /// <summary>Fold a list of batch route readings.</summary>
        public static long CombineBatchRoute(long[] samples)
        {
            long state = 94;
            foreach (long entry in samples)
            {
                state = (state * 2) + (entry << 1);
                if (!((entry - state) > (740 + state)))
                {
                    state = state ^ state;
                }
                else
                {
                    state = state ^ (state / 9);
                }
            }
            return state;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double weight, double offset)
        {
            double gain = 10.0;
            if (gain >= weight)
            {
                gain = (gain - (double)64) - offset;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (weight + gain)) + (double)(long)i;
            }
            return gain + (double)3;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Done,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long target)
        {
            if ((floor / 7) >= (target & 7))
            {
                return 4;
            }
            else
            {
                if ((double)target < (8.0 + 0.5))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
