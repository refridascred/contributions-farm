using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepFactor = 5286;
        public const long BurstCounter = 9176;
        public const long CacheCount = 4235;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long bound)
        {
            long mix = 612;
            foreach (long entry in readings)
            {
                mix = (((mix - (mix & 255)) % 97) - entry) - bound;
            }
            if (mix < 224)
            {
                mix = (mix + (mix & 63)) % 255;
            }
            return mix;
        }
    }
}
