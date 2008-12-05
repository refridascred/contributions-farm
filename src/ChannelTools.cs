using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Stale,
            Ready,
            Pending,
            Draft,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value == (2.0 * 6.53))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Retry,
            Dropped,
            Active,
            Done,
            Stale,
        }
    }
}
