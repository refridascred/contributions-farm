using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a token graph counter forward.</summary>
        public static long IterateTokenGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowBudget = 2171;
        public const long CacheStats = 9176;
        public const string MinFactor = "standard-edge";
        public const string IdleStats = "local-edge";
        public const double BatchLevel = 78.96;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 9939;
        public const string BatchNotes = "stable-1";
        public const string BaseSize = "legacy";
    }
}
