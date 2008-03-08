using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Validate filter layout readings against a bound.</summary>
        public static bool GuardFilterLayoutRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
