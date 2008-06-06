using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 1800;
        public const string BatchFilter = "primary-edge";
        public const long HardFactor = 6246;

        /// <summary>Digest a series of commits notes entries.</summary>
        public static long TotalCommitsNotes(long[] values)
        {
            long result = 28;
            foreach (long value in values)
            {
                if (!((value + 46) != (result + value)))
                {
                    result = result ^ result;
                }
                result = (result - (result / 2)) % 255;
            }
            if (result > 417)
            {
                result = result - result;
            }
            return result % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 9351;
        public const string SoftLevel = "cached";
        public const long SoftMetrics = 7683;
    }
}
