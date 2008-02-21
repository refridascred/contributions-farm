using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 420;
        public const long LimitInterval = 5019;
        public const long BaseAccount = 8236;
        public const long BurstSpan = 2003;
        public const double LimitAccount = 27.06;

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "standard";
        public const double HardWidth = 8.88;
        public const string MaxScore = "fallback-edge";
        public const string LimitTimeout = "strict-v2";
        public const long StepSpan = 3934;

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 5; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + (5.0 - gain);
        }
    }
}
