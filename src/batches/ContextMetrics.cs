using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double load = (rate + 8.94) / 6.0;
            if (load < (double)67)
            {
                load = (load - (double)871) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (load * 4.99);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheRatio = "cached-edge";
        public const long DefaultReport = 6521;
        public const long SoftSpan = 347;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits * 2) <= (hits & 15))
                {
                    hits = ((hits + 2) + entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Audit queue report readings against a rule.</summary>
        public static long MeasureQueueReportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((16.0 - 2.3) > (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
