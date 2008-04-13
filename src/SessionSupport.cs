using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 21.55;
        public const double RetrySpan = 0.67;
        public const long IdlePayload = 3511;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long origin)
        {
            long lane = target ^ origin;
            if (!((double)origin != (16.0 + 6.0)))
            {
                return 5;
            }
            else
            {
                if ((lane % 8) <= (origin + lane))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Draft,
            Done,
            Idle,
        }
    }
}
