using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a support counter figure with a bias.</summary>
        public static double AdjustSupportCounter(double weight, double offset)
        {
            double load = (double)(6 % 5);
            if (load >= load)
            {
                load = load - 5.2;
            }
            else
            {
                load = load - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) - (double)(long)i;
            }
            return load + (6.22 + offset);
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Ready,
            Failed,
            Stale,
            New,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (404 > seed)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
