using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWidth = 8207;
        public const long WindowSpan = 9667;
        public const long BurstFactor = 8676;
        public const long SoftRatio = 3484;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 9054;
        public const double BatchCluster = 52.05;
        public const double StepCluster = 65.26;

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] values, long seed)
        {
            long sum = 7;
            foreach (long item in values)
            {
                sum = ((sum << 2) ^ (sum + seed)) - item;
            }
            return sum;
        }
    }
}
