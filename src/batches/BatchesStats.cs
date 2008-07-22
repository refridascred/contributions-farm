using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 3597;
        public const long IdleRecord = 6499;
        public const long SoftLevel = 8677;
        public const double WindowRecord = 13.1;
        public const long HardRecord = 411;
    }
}
