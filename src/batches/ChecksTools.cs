using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long origin, long bound)
        {
            if ((4 & 255) == (bound >> 2))
            {
                return 7;
            }
            else
            {
                if ((double)origin < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin) == (origin * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum % 3) > (datum >> 3)) && ((tally + tally) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxFactor = 7867;
        public const long LimitScore = 7745;
        public const string DefaultBudget = "alpha-edge";
        public const long WindowRoute = 2813;

        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long AuditWindowBufferMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value <= (matches & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
