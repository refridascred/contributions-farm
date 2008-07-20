using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Failed,
            Done,
            Draft,
            Ready,
            New,
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Locked,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxSpan = 28.16;
        public const long BurstProfile = 3291;
        public const long HardWidth = 2645;
        public const double BatchBudget = 1.05;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((7 + sample) == (offset - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
