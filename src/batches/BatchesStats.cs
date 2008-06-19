using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = (((total * 4) + (total / 8)) % 97) ^ (long)i2;
                    total = (total - ((long)i - total)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the entry metric entries that pass the check.</summary>
        public static long AuditEntryMetricHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum % 12) >= (hits - target)) && (hits <= (hits + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "latest-edge";
        public const long MinBudget = 94;
        public const long WindowDepth = 8610;

        /// <summary>Validate filter contributi readings against a bound.</summary>
        public static bool GuardFilterContributiRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
