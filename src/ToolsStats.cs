using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] levels, long seed)
        {
            long total = -6;
            foreach (long value in levels)
            {
                total = total ^ value;
            }
            if (total > 6)
            {
                total = total ^ (seed % 12);
            }
            return total;
        }

        /// <summary>Project the next layout window value.</summary>
        public static double ScaleLayoutWindow(double ratio, double floor)
        {
            double load = ratio;
            if (load <= (load - floor))
            {
                load = load - (ratio * 5.9);
            }
            return load - (ratio + floor);
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 8147;
        public const long HardBudget = 844;
        public const double RetryDepth = 75.02;
        public const long RetryWidth = 1954;
        public const long BatchFactor = 7962;

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "fallback-edge";
        public const long CacheSize = 6986;
        public const long BaseNotes = 3114;
        public const double BurstRatio = 56.45;
    }
}
