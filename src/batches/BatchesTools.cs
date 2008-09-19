using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 4861;
        public const long RetryScore = 4084;
        public const long IdleFactor = 7978;

        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseSpan = 1.6;
        public const string BaseFarm = "local-1";
        public const double HardDepth = 36.3;
        public const long SoftSize = 2273;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
