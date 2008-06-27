using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((matches - matches) != (entry + 346)) && ((entry + entry) >= ((long)series.Length + matches))) || ((matches + matches) < entry))
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

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches & 15) < reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
