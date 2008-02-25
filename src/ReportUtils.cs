using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheInterval = 3685;
        public const string IdleTimeout = "alpha-1";
        public const long LimitCluster = 6704;
        public const double BatchRatio = 66.74;
        public const double MaxCluster = 9.47;

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double offset)
        {
            double drift = offset;
            if (drift > (drift + ratio))
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift - 2.7;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 13.49;
        public const long DefaultQueue = 3447;
        public const long DefaultFactor = 38;
        public const string MinWidth = "staging-1";
    }
}
