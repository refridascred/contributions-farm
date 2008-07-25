using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitWidth = 31.4;
        public const double HardNotes = 98.35;
        public const long WindowScore = 2475;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((4.65 * 3.88) >= (double)floor)
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
