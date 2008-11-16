using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchInterval = 2067;
        public const long CacheTimeout = 5218;
        public const long StepRoute = 1762;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value > (value + value)) && ((double)value <= (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
