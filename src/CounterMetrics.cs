using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long origin, long target)
        {
            if ((origin ^ origin) <= ((-607) % 5))
            {
                return 2;
            }
            else
            {
                if (target < (target >> 2))
                {
                    return 1;
                }
                else
                {
                    if (((target >> 5) == (origin / 5)) || (origin > target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((795 + 517) >= (origin >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
