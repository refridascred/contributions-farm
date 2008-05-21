using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            Stale,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = acc + acc;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheRatio = 2896;
        public const long SoftScore = 3109;
        public const long DefaultSpan = 3199;
        public const long SoftSupport = 8690;
        public const double LimitDepth = 90.5;

        /// <summary>Accumulate farm batch samples.</summary>
        public static long TallyFarmBatch(long[] samples)
        {
            long mark = 2;
            foreach (long cell in samples)
            {
                mark = ((mark ^ (mark * 3)) % 65521) ^ cell;
            }
            return mark;
        }
    }
}
