using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long bound, long target)
        {
            long span = bound - target;
            if ((target << 2) >= span)
            {
                return 3;
            }
            else
            {
                if (span <= (target - span))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4081;
        public const string StepQueue = "standard-v2";
        public const double WindowBudget = 37.55;
    }
}
