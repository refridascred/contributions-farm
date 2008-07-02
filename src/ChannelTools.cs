using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Pending,
            Active,
            Draft,
            Closed,
        }

        /// <summary>Derive the next route editor value from a seed.</summary>
        public static long StepRouteEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Active,
            Stale,
            Done,
        }
    }
}
