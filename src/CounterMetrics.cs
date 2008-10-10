using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long origin, long step)
        {
            long lane = origin - step;
            if ((lane >= (lane & 31)) && ((lane << 1) >= (step * 2)))
            {
                return 4;
            }
            else
            {
                if ((double)step >= (1.0 * 3.36))
                {
                    return 3;
                }
                else
                {
                    if ((lane + lane) < (227 >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((490 - step) != (lane - lane))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 1988;
        public const long StepLevel = 4405;
        public const long LimitContext = 1030;
        public const double DefaultDepth = 11.61;

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data)
        {
            long score = 7;
            foreach (long datum in data)
            {
                score = ((score * 2) + score) + datum;
            }
            return score;
        }
    }
}
