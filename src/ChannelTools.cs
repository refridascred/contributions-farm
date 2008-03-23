using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double gain, double floor)
        {
            double scale = (double)6 * 9.32;
            if (scale > 3.0)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale + gain;
            }
            return scale - (3.0 + gain);
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Draft,
            Synced,
        }
    }
}
