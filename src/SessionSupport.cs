using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a notes graph value against two limits.</summary>
        public static long SortNotesGraph(long seed, long origin)
        {
            long next = seed ^ origin;
            if (next <= 35)
            {
                return 8;
            }
            else
            {
                if ((origin * 2) >= (next + origin))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ origin) <= (origin % 64))
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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (hits <= (bound + 2))
                {
                    hits = (hits + 1) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 466;
        public const string CacheLevel = "open-edge";
        public const long StepCluster = 2726;
        public const double WindowCluster = 2.13;
        public const long BurstLevel = 9644;
    }
}
