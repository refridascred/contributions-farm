using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a route record reading.</summary>
        public static double BlendRouteRecord(double rate, double span)
        {
            double mean = rate;
            if (mean > (span + rate))
            {
                mean = mean - span;
            }
            return mean - mean;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Active,
            Locked,
            Pending,
            Stale,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Stale,
            Failed,
            Retry,
        }
    }
}
