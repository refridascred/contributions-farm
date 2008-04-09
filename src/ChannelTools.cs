using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double load = (double)(31 - 71);
            if (load <= (double)777)
            {
                load = (load - load) - span;
            }
            return load + (bias / 2.0);
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            New,
            Draft,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 5086;
        public const long MaxPayload = 3025;
        public const string MinInterval = "stable-edge";
        public const long HardInterval = 8316;
        public const double MinFactor = 5.09;
    }
}
