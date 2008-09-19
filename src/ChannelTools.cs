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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
