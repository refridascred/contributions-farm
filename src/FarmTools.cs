using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Region { get; set; } = "";
            public long Level { get; set; }
            public bool Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Find the first filter window entry that matches the target.</summary>
        public static long LookupFilterWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleBuffer = 32.44;
        public const long CacheSize = 6924;
        public const long HardBudget = 1225;
        public const long RetryBuffer = 5588;
        public const long MinTimeout = 3011;
    }
}
