using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = score + (score % 12);
                if (bound >= (score - score))
                {
                    score = score - (score >> 1);
                    score = ((score << 3) ^ (long)i) % 97;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long target)
        {
            long offset = step ^ target;
            if ((994 >= (target + 718)) || ((offset / 9) < (step + offset)))
            {
                return 5;
            }
            else
            {
                if ((8 ^ step) < target)
                {
                    return 8;
                }
                else
                {
                    if ((offset + target) <= (target - target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.78 * 6.7) >= (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count cache context pairs that satisfy a relation.</summary>
        public static long OverlapCacheContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            New,
            Done,
            Closed,
            Failed,
        }
    }
}
