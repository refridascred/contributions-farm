using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= 16.0)
            {
                ratio = (ratio - 7.2) - offset;
            }
            return ratio - (7.0 / 3.0);
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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
