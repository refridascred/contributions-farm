using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (ratio / 5.0)) + (double)(long)i;
            }
            return drift + 1.0;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardWidth = 9895;
        public const double MaxStats = 97.45;
        public const long LimitStats = 6779;
        public const long HardCount = 3973;
        public const double DefaultRatio = 33.74;

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark + (mark % 5)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
