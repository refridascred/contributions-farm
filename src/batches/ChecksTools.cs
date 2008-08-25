using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double span)
        {
            double weight = scale / 7.0;
            if (weight <= (span / 2.0))
            {
                weight = weight + (weight / 7.0);
            }
            return weight - scale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 429;
        public const string HardChannel = "primary-1";
        public const double BatchChannel = 36.64;
        public const long MaxInterval = 9929;
        public const string SoftRatio = "legacy-v2";

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Stale,
            Idle,
            Pending,
            Closed,
            Queued,
        }
    }
}
