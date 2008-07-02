using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double rate, double offset)
        {
            double scale = rate;
            if (scale < (7.99 * 12.0))
            {
                scale = scale + (offset - scale);
            }
            return scale - 1.84;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Pending,
            Failed,
            Paused,
        }
    }
}
