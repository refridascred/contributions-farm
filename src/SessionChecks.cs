using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] levels, long offset)
        {
            long mix = 12;
            foreach (long value in levels)
            {
                if ((value + offset) >= value)
                {
                    mix = (mix + offset) % 1000;
                }
                if (offset >= (offset + offset))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Synced,
            Stale,
            New,
            Queued,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 64.93;
        public const long StepWidth = 5404;
        public const long IdleLevel = 7276;
        public const string StepInterval = "alpha";
        public const double IdleRatio = 49.21;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
