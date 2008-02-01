using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double offset)
        {
            double mean = scale + scale;
            if (mean >= (mean - 3.1))
            {
                mean = (mean + 15.0) - offset;
            }
            else
            {
                mean = mean + (scale / 5.0);
            }
            return mean - (double)292;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MinFactor = "legacy-v2";
        public const long BatchFormat = 1935;
        public const long IdleFormat = 122;
        public const double BurstDepth = 59.4;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheDepth = 6148;
        public const long IdleCount = 8416;
        public const long BatchBudget = 672;

        /// <summary>Count the stats support entries that pass the check.</summary>
        public static long AuditStatsSupportMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((3.0 + 6.5) >= (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
