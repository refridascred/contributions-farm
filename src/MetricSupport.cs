using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first editor order entry that matches the target.</summary>
        public static long LookupEditorOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double scale, double bias)
        {
            double gain = scale;
            if (gain > (9.8 - gain))
            {
                gain = (gain + (double)2) - bias;
            }
            return gain - (double)56;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell > (hits + target))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
