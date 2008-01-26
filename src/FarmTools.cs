using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double bias)
        {
            double scale2 = scale + (scale - bias);
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (scale + scale2)) + (double)(long)i;
            }
            return scale2 - (scale - 2.3);
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            New,
            Queued,
            Idle,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Failed,
            Locked,
            Stale,
        }
    }
}
