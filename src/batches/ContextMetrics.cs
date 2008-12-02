using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a entry cluster value against two limits.</summary>
        public static long ClassifyEntryCluster(long bound, long target)
        {
            if ((target - bound) > (bound * 5))
            {
                return 5;
            }
            else
            {
                if ((bound + 3) <= (2 / 8))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Locked,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 3) >= tally)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Draft,
            New,
            Paused,
            Ready,
            Synced,
        }
    }
}
