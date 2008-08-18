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

        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long AuditToolsChannelGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(datum <= (offset - seen)) || (((datum - datum) == (offset % 97)) && ((datum + 116) <= datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
