using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Blend two buffer metrics measurements.</summary>
        public static double AdjustBufferMetrics(double scale, double span)
        {
            double load = 6.3;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (double)(long)i) + scale) - span;
            }
            return load + (load + load);
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            New,
            Locked,
            Retry,
        }
    }
}
