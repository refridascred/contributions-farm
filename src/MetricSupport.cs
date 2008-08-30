using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 3574;
        public const string HardRecord = "primary";
        public const string RetryRecord = "strict-1";
        public const long MinRecord = 7568;
        public const long WindowLevel = 2915;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
