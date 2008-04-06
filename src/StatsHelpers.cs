using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Pending,
            Active,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleSize = 7444;
        public const long DefaultFactor = 8659;
        public const double BaseScore = 86.52;
        public const long RetryFilter = 7966;

        /// <summary>Locate a account farm reading by value.</summary>
        public static long LookupAccountFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((hits & 1) == (hits & 63)) || ((9 - hits) <= (hits + hits))) && ((hits - origin) > (hits & 3)))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Pending,
            Dropped,
            Closed,
            Synced,
        }
    }
}
