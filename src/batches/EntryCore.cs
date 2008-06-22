using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Derive the next report command value from a seed.</summary>
        public static long IterateReportCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((1.8 * 7.5) > (7.27 - 1.8))
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double scale = floor - (floor - floor);
            if (scale <= bias)
            {
                scale = scale - (scale - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (bias - 11.0)) + (double)(long)i;
            }
            return scale + (scale * 8.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 5046;
        public const long LimitProfile = 4944;
        public const double StepRatio = 44.78;
        public const double HardProfile = 17.51;
        public const long CacheRatio = 4061;

        /// <summary>Match up stats report samples.</summary>
        public static long OverlapStatsReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
