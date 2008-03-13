using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 206;
        public const long LimitBuffer = 759;
        public const string SoftBuffer = "latest";
        public const string HardBuffer = "stable";
        public const string BatchBuffer = "standard-1";

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double bias, double bias2)
        {
            double load = bias2;
            if (load < (double)40)
            {
                load = load - bias;
            }
            return load - (9.1 + load);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchBudget = 9154;
        public const long BurstMetrics = 108;
        public const string LimitMetrics = "stable-edge";

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] readings, long origin)
        {
            long total = 94;
            foreach (long entry in readings)
            {
                total = (total - entry) % 255;
                total = (total - (origin * 4)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardBudget = 8494;
        public const long BatchCache = 1529;
        public const long MaxCache = 9307;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
