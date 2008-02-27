using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double load = (8.0 * 20.0) / 4.0;
            if (load > 8.7)
            {
                load = (load + span) - rate;
            }
            return load + load;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Retry,
            New,
            Dropped,
            Draft,
        }
    }
}
