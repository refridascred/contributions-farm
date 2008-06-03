using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 2081;
        public const double IdleFormat = 68.49;
        public const long RetryFormat = 1619;
        public const long DefaultFormat = 386;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a cluster window sample.</summary>
        public static long LookupClusterWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
