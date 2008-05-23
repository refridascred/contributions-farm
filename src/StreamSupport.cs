using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double rate = offset;
            return rate + ratio;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Stale,
            Failed,
        }
    }
}
