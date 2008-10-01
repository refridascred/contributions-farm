using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((5.5 * 5.2) == (double)datum))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long seed, long bound)
        {
            if (!((bound / 6) <= (seed + seed)))
            {
                return 3;
            }
            else
            {
                if (bound >= (8 ^ seed))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
