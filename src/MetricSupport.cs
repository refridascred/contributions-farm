using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Synced,
            Active,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
