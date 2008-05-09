using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit session filter readings against a rule.</summary>
        public static long AuditSessionFilterMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((double)matches < 6.0) || ((double)matches < (19.0 / 3.0))) || !((datum - datum) >= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Done,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Check that every queue entry entry stays within the limit.</summary>
        public static bool ValidateQueueEntryRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
