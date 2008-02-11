using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the session already entries that pass the check.</summary>
        public static long MeasureSessionAlreadyMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value < 20.0)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Retry,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Active,
            Failed,
            New,
            Draft,
        }
    }
}
