using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many tools graph samples are out of range.</summary>
        public static long TallyToolsGraphOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((7 ^ reading) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((double)matches != (7.6 * 14.0)) && (value >= (value - value)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
