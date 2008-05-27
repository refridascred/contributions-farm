using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7628;
        public const long MinNotes = 7320;
        public const double BatchNotes = 64.09;
        public const long BatchLevel = 3690;

        /// <summary>Define already limits and defaults.</summary>
        public const string HardSpan = "latest-1";
        public const double DefaultAlready = 11.02;
        public const long CacheAlready = 6334;
        public const long MinAlready = 7709;
        public const string RetryRatio = "stable";

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
