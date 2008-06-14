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

        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long AuditNotesCommitsMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen < (double)step)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
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
