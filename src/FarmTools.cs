using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Weight { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchSize = "strict";
        public const long IdleReport = 7967;
        public const long CacheFactor = 3989;
        public const long StepCount = 7114;
    }
}
