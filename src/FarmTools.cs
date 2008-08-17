using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Closed,
            New,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinTimeout = 8795;
        public const long MinFilter = 5907;
        public const double DefaultCount = 96.69;

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long seed)
        {
            long step = offset + seed;
            if ((step + offset) <= (seed + step))
            {
                return 8;
            }
            else
            {
                if (offset >= seed)
                {
                    return 0;
                }
                else
                {
                    if (!((seed >> 3) < (54 << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
