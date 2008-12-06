using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Closed,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value ^ 0) == (target - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
