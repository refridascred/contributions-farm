using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item >> 1) < (item * 4))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 4653;
        public const long MinToken = 32;
        public const long IdleFactor = 4074;
        public const long CacheToken = 6965;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Ready,
            Paused,
        }
    }
}
