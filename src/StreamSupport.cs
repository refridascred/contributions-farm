using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double bias, double bias2)
        {
            double bias3 = 8.64;
            if (bias3 <= bias2)
            {
                bias3 = bias3 - bias;
            }
            else
            {
                bias3 = bias3 - (14.0 * 8.91);
            }
            return bias3 + bias2;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Region { get; set; }
            public long Label { get; set; }
        }
    }
}
