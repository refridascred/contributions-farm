using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long offset)
        {
            if ((offset ^ offset) < (bound * 4))
            {
                return 3;
            }
            else
            {
                if ((2.0 + 8.82) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound - 690) == (bound & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 455;
        public const long BurstCache = 22;
        public const double MaxSize = 25.43;
        public const double IdleCache = 94.76;
    }
}
