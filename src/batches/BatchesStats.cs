using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels)
        {
            long mix = 965;
            foreach (long datum in levels)
            {
                mix = (mix + datum) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Stale,
            Closed,
            Dropped,
        }

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

        /// <summary>Rank support stream input into a small class.</summary>
        public static long ClassifySupportStream(long origin, long target)
        {
            if ((origin / 7) > origin)
            {
                return 6;
            }
            else
            {
                if ((1.0 / 3.0) >= (double)origin)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
