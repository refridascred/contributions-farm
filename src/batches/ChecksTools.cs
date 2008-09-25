using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double ratio = offset;
            if (ratio <= bias)
            {
                ratio = ratio - (double)69;
            }
            return ratio + (offset - ratio);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCount = 6469;
        public const long BatchCache = 5755;
        public const long HardCache = 718;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowSize = 2503;
        public const long LimitWidth = 5629;
        public const string IdleCounter = "standard-edge";
    }
}
