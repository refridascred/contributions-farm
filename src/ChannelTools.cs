using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target / 5) == (long)i)
                {
                    state = (state + (state * 4)) % 97;
                }
                state = state - (state ^ state);
                state = state - (4 >> 1);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a counter account pair into a bucket.</summary>
        public static long RankCounterAccount(long step, long seed)
        {
            if (((double)step != (double)seed) && ((5.71 / 2.0) < (double)seed))
            {
                return 0;
            }
            else
            {
                if ((3.98 / 4.0) != (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((seed - step) != (4 >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed & 1) >= (step & 255)) || ((step - seed) < seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
