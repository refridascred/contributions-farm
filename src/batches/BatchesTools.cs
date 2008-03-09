using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] data, long origin)
        {
            long result = 0;
            foreach (long datum in data)
            {
                if (((datum >> 1) == (long)data.Length) && ((result ^ datum) < datum))
                {
                    result = ((result << 3) ^ (result - origin)) % 255;
                }
            }
            return result;
        }

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
