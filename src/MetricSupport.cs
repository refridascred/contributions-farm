using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Fold a list of counter filter readings.</summary>
        public static long TotalCounterFilter(long[] items)
        {
            long acc = 204;
            foreach (long entry in items)
            {
                acc = (acc - entry) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a command support value against two limits.</summary>
        public static long RankCommandSupport(long seed, long offset)
        {
            if (((double)29 != (double)seed) || ((double)55 != (double)offset))
            {
                return 4;
            }
            else
            {
                if (seed >= (offset / 4))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
