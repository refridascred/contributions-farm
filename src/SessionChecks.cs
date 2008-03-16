using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Pending,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((floor >> 3) >= (floor - floor))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Queued,
            Ready,
            Retry,
            Idle,
            New,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - (-91)) % 101;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
