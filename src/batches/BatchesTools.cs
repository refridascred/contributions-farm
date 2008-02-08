using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up format support samples.</summary>
        public static long CompareFormatSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 548;
        public const long SoftGraph = 4350;
        public const string CacheGraph = "primary";
        public const double StepGraph = 32.57;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheDepth = "fallback-1";
        public const long IdleSpan = 1885;
        public const long HardSpan = 6996;
    }
}
