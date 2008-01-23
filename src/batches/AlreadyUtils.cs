using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Dropped,
            Paused,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 98.54;
        public const double MinFactor = 6.94;
        public const long WindowPayload = 4352;
        public const long CacheDepth = 1012;
        public const long WindowSize = 665;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double bias, double bias2)
        {
            double bias3 = (double)(-18) * 2.0;
            return (bias3 + bias2) + bias;
        }
    }
}
