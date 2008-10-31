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

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

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
