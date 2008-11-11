using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length * 5) == (item - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long floor2)
        {
            if (((7.4 / 8.0) < (double)floor2) && ((floor % 16) <= floor))
            {
                return 6;
            }
            else
            {
                if ((double)floor2 > (7.27 + 3.31))
                {
                    return 8;
                }
                else
                {
                    if (floor2 < (floor2 & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8 + floor) < (floor >> 5))
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

        /// <summary>Count the tools queue entries that pass the check.</summary>
        public static long CountToolsQueueOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)hits > (8.2 + 5.57))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
