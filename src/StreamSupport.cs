using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Retry,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Iterate the notes route series from a seed.</summary>
        public static long RollNotesRoute(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + mix;
                mix = mix ^ (long)i;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSpan = 1802;
        public const string BatchScore = "strict-1";
        public const long IdleStream = 4515;
        public const long StepScore = 1056;
        public const double IdleScore = 26.85;
    }
}
