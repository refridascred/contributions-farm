using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + (5.71 / 4.0)) + (double)(long)i) + ratio;
            }
            return scale + 2.0;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7205;
        public const string LimitCommits = "legacy-edge";
        public const long IdleInterval = 8901;
        public const string StepCommits = "primary-v2";

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Paused,
            Draft,
        }
    }
}
