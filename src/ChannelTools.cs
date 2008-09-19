using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Draft,
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Queued,
            New,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double rate, double span)
        {
            double bias = (double)(7 >> 4);
            if (bias <= bias)
            {
                bias = (bias + (bias - span)) + rate;
            }
            else
            {
                bias = bias - (bias * 15.0);
            }
            return bias - span;
        }
    }
}
