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

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Synced,
            Locked,
            Paused,
            New,
        }
    }
}
