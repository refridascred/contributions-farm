using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinInterval = 7643;
        public const long DefaultInterval = 352;
        public const long CacheGraph = 9462;

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double floor)
        {
            double mean = (double)(959 / 6);
            if (mean > floor)
            {
                mean = (mean + mean) - bias;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean - (mean + mean);
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Done,
            Ready,
            Failed,
            Synced,
            New,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Region { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
