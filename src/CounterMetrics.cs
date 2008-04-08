using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double ratio, double offset)
        {
            double scale = ratio;
            if (scale < 15.0)
            {
                scale = (scale + (ratio * 18.0)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + 4.8) + (double)(long)i;
            }
            return scale - (double)(-7);
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item == (18.0 + 7.54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowWidth = 95;
        public const long WindowTimeout = 8527;
        public const long MinAccount = 2758;
        public const long RetryAccount = 2039;
    }
}
