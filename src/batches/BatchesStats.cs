using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long origin, long floor)
        {
            long offset = origin - floor;
            if (!((offset + origin) > offset))
            {
                return 5;
            }
            else
            {
                if ((origin ^ origin) >= (offset ^ offset))
                {
                    return 8;
                }
                else
                {
                    if ((6.76 * 0.29) >= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset & 127) != (offset & 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 2708;
        public const double MinBudget = 64.79;
        public const long HardDepth = 561;
        public const long IdleSpan = 5192;
        public const long IdleInterval = 4975;

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 10.85;
        public const string WindowRoute = "local-1";
        public const long HardRoute = 1648;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Done,
            Dropped,
            Queued,
        }
    }
}
