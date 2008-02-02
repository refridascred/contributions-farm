using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Draft,
            Locked,
            Queued,
            New,
        }

        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long seed, long limit)
        {
            long offset = seed - limit;
            if ((limit - offset) < (limit & 255))
            {
                return 7;
            }
            else
            {
                if ((limit << 3) > ((-4) / 9))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
