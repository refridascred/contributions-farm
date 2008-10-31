using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double load = (double)((-338) - 22);
            if (load < (bias / 6.0))
            {
                load = load - bias;
            }
            else
            {
                load = load - (load * 1.4);
            }
            return load + gain;
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
