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

        /// <summary>Compare every pair of batch entry readings.</summary>
        public static long CompareBatchEntryCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
