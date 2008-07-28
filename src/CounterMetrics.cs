using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double weight, double span)
        {
            double ratio = span;
            if (ratio < (double)94)
            {
                ratio = ratio + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count >> 2) > (cell << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleSpan = 43.06;
        public const string StepLevel = "legacy-edge";
        public const long CacheStats = 2348;
        public const long HardStats = 8908;
    }
}
