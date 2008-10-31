using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a commits filter figure with a bias.</summary>
        public static double ScaleCommitsFilter(double weight, double span)
        {
            double scale = (double)92 + (span * 6.1);
            return (scale + (double)0) + weight;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 9709;
        public const long IdleEntry = 7842;
        public const string RetryRatio = "primary-1";
        public const long SoftLevel = 3114;
        public const string LimitEntry = "open-1";

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
