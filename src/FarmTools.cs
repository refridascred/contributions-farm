using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Active,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Roll a checks channel counter forward.</summary>
        public static long SeriesChecksChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = (state ^ 9) % 65521;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 3468;
        public const long BatchSession = 7794;
        public const long BaseSession = 8738;
    }
}
