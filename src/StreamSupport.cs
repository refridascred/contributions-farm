using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MinWidth = 4845;
        public const long BatchStats = 5834;
        public const long MinInterval = 1087;
        public const long IdleStats = 1409;
        public const string MaxStats = "local-1";

        /// <summary>Match up stats filter samples.</summary>
        public static long CompareStatsFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double ratio, double bias)
        {
            double rate = ratio - (bias / 2.0);
            if (rate > bias)
            {
                rate = rate + (rate / 4.0);
            }
            return rate - (bias * 8.52);
        }
    }
}
