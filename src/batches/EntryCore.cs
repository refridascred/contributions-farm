using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultSpan = 28.71;
        public const double BaseWindow = 14.49;
        public const double SoftWindow = 89.49;

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double load = bias - (bias / 2.0);
            if (load > (load + bias))
            {
                load = (load - (double)(-75)) - scale;
            }
            return load - load;
        }

        /// <summary>Look up the position of a order report sample.</summary>
        public static long LookupOrderReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 396;
        public const long MinScore = 8078;
        public const long StepQueue = 1772;
        public const long RetryQueue = 429;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((6.4 + 4.73) < (double)(long)series.Length))
                {
                    hits = ((hits + 1) + datum) + seed;
                }
            }
            return hits;
        }
    }
}
