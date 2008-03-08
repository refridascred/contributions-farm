using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (double)1)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry <= (seen ^ 46))
                {
                    seen = (seen + 3) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long seed, long target)
        {
            if ((seed + target) >= (target - target))
            {
                return 0;
            }
            else
            {
                if (target > (target >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((887 / 4) >= (target + target))
                    {
                        return 4;
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
