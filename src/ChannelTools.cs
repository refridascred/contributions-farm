using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry << 2) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (20.0 / 6.0))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Idle,
            Queued,
            Active,
            Paused,
            Pending,
        }
    }
}
