using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepWidth = 60.18;
        public const long LimitLevel = 24;
        public const long BurstFactor = 2714;

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long seed)
        {
            if (((seed ^ 6) != (7 * 3)) && ((12.0 - 8.2) > (double)seed))
            {
                return 4;
            }
            else
            {
                if ((8.64 / 2.0) < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) != (seed ^ seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed & 3) != (target - target)) || (1.3 <= (double)target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] values, long limit)
        {
            long state = 97;
            foreach (long datum in values)
            {
                if (state > (datum << 2))
                {
                    state = state - datum;
                }
            }
            if (state < 392)
            {
                state = (state - (state + limit)) % 4096;
            }
            return state;
        }
    }
}
